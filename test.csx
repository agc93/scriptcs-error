#r "BuildTool/bin/Debug/BuildTool.dll"
using BuildTool;
using System.IO;
var t = typeof(BuildPack);
System.Diagnostics.Debugger.Launch();
var tool = Require<BuildPack>();

tool.Run(Path.Combine(Environment.CurrentDirectory, "WpfApplication", "WpfApplication.csproj"));