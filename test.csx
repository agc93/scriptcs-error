#r "TestPack/bin/Debug/TestPack.dll"
using ScriptCsTest;

//System.Diagnostics.Debugger.Launch();
var tool = Require<TestPack>();
tool.Hello("World");