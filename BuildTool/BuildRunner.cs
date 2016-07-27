using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;

namespace BuildTool
{
    /// <summary>
    /// This class is just abstracting the MSBuild implementation details away from the script pack
    /// </summary>
    internal static class BuildRunner
    {
        private static BuildManager Manager => Microsoft.Build.Execution.BuildManager.DefaultBuildManager;

        internal static void Build(string projectFilePath) {
            var pc = new ProjectCollection();
            if (!File.Exists(projectFilePath))
            {
                throw new FileNotFoundException(
                    $"Project file not found at path {projectFilePath}! Please ensure you have provided a valid csproj file.",
                    projectFilePath);
            }
            Log("Configuring build environment");
            var path = Path.Combine(Environment.CurrentDirectory, "BuildOutput");
            Directory.CreateDirectory(path);
            var props = new Dictionary<string, string>
            {
                {"Configuration", "Debug"},
                {"Platform", "AnyCPU"},
                {"OutputPath", path + "\\"}
            };
            var targets = new List<string> { "PrepareForBuild", "Clean", "Build", "Publish" };
            Log($"Build configured for targets: {string.Join(", ", targets)}");
            var buildParams = new BuildParameters(pc)
            {
                DetailedSummary = true,
                DefaultToolsVersion = "14.0"
            };
            var reqData = new BuildRequestData(projectFilePath, props, "14.0", targets.ToArray(), null);
            Log("Preparing for build");
            try
            {
                Manager.BeginBuild(buildParams);
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("in progress"))
            {
                throw new InvalidOperationException("Operation in progress");
            }
            Log("Starting MSBuild build");
            try
            {
                var buildResult = Manager.BuildRequest(reqData);
                Log($"MSBuild build complete: {buildResult.OverallResult}");
            }
            catch (InvalidCastException ex)
            {
                Log("We just caught an invalid cast since we're using Microsoft.Build 14 with WPF tasks (v4)");
                Log(ex.Message);
            }
        }

        private static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
