using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReferencedLib;
using ScriptCs.Contracts;

namespace BuildTool
{
    public class BuildPack : IScriptPackContext
    {
        

        public void Run(string projectFilePath)
        {
            BuildRunner.Build(projectFilePath);
        }
    }

    public class BuildScriptPack : ScriptPack<BuildPack>
    {
        public override IScriptPackContext GetContext()
        {
            return new BuildPack();
        }

        public override void Initialize(IScriptPackSession session)
        {
            session.AddReference(MSBuildResolver.GetMSBuildPath("Microsoft.Build"));
            session.AddReference(MSBuildResolver.GetMSBuildPath("Microsoft.Build.Framework"));
            session.AddReference(MSBuildResolver.GetMSBuildPath("Microsoft.Build.Tasks"));
            session.AddReference(MSBuildResolver.GetMSBuildPath("Microsoft.Build.Utilities"));

            session.ImportNamespace("Microsoft.Build");
            session.ImportNamespace("Microsoft.Build.Framework");
            session.ImportNamespace("Microsoft.Build.Evaluation");
            session.ImportNamespace("Microsoft.Build.Execution");

            session.ImportNamespace("BuildTool");

            base.Initialize(session);

            
        }
    }
}
