using System.IO;
//System.Diagnostics.Debugger.Launch();
var tool = Require<BuildPack>();

tool.Run(Path.Combine(Environment.CurrentDirectory, "WpfApplication", "WpfApplication.csproj"));