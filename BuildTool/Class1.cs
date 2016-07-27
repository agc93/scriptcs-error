using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Evaluation;
using Microsoft.Build.Execution;
using Microsoft.Build.Framework;
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
            base.Initialize(session);
            session.AddReference("Microsoft.Build.Framework");
            session.AddReference("Microsoft.Build.Utilities");
            session.AddReference("Microsoft.Build.Tasks");
            session.ImportNamespace("BuildTool");
        }
    }
}
