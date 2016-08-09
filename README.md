## Testing

Build the `BuildTool` project, and copy `BuildTool.dll`, `ReferencedLib.dll` and `ScriptCs.Contracts.dll` to the `scripts/bin` directory and run `test.csx` to test.

---

## Background

The `WpfApplication` project is just there as a dummy: the binding redirect is needed for building WPF (uses MSBuild 4) apps using C# 6 (requires MSBuild 14). `msbuild.exe.config` (you should be able to find it on your PC), uses the following to achieve that:

```xml
<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
    <dependentAssembly>
        <assemblyIdentity name="Microsoft.Build" publicKeyToken="b03f5f7f11d50a3a" culture="neutral"/>
        <bindingRedirect oldVersion="0.0.0.0-99.9.9.9" newVersion="14.0.0.0"/>
    </dependentAssembly>
</assemblyBinding>
```

I'm basically trying to achieve the same thing using scriptcs.

---

## Output

Here is basically what I get from running the above:

```
DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IAppDomainAssemblyResolver
DEBUG: [ScriptCs.Hosting.InitializationServices] Registering initialization services
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IFileSystem
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IAssemblyUtility
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageContainer
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageAssemblyResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IAssemblyResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IInstallationProvider
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageInstaller
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Hosting.IModuleLoader
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IAppDomainAssemblyResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IFilePreProcessor
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Autofac to version:3.3.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Autofac.Integration.Mef to version:3.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Common.Logging to version:2.1.2.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ICSharpCode.NRefactory.CSharp to version:5.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ICSharpCode.NRefactory to version:5.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.CodeAnalysis.CSharp to version:1.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.CodeAnalysis.Desktop to version:1.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.CodeAnalysis to version:1.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.CodeAnalysis.Scripting.CSharp to version:1.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.CodeAnalysis.Scripting to version:1.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Microsoft.Web.XmlTransform to version:2.1.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Mono.Cecil to version:0.9.5.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Mono.CSharp to version:4.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly Newtonsoft.Json to version:6.0.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly NuGet.Core to version:2.8.60717.93
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly PowerArgs to version:2.0.4.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ScriptCs.Contracts to version:0.16.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ScriptCs.Core to version:0.16.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ScriptCs.Engine.Mono to version:0.16.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ScriptCs.Engine.Roslyn to version:0.16.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly ScriptCs.Hosting to version:0.16.0.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly System.Collections.Immutable to version:1.1.33.0
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly System.Reflection.Metadata to version:1.0.18.0 DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly scriptcs to version:0.16.0.0
DEBUG: [ScriptCs.AssemblyResolver] Found assembly in bin folder: BuildTool.dll
DEBUG: [ScriptCs.AssemblyResolver] Found assembly in bin folder: ScriptCs.Contracts.dll
DEBUG: [ScriptCs.AppDomainAssemblyResolver] Mapping Assembly BuildTool to version:1.0.0.0
DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IModuleLoader
DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IFileSystem
DEBUG: [ScriptCs.Hosting.ModuleLoader] Only CSharp module is needed - will skip module lookup
DEBUG: [ScriptCs.Hosting.ModuleLoader] Initializing module: System.Reflection.RuntimeAssembly
DEBUG: [ScriptCs.Hosting.ScriptServicesBuilder] Resolving ScriptServices
DEBUG: [ScriptCs.Hosting.ScriptServicesBuilder] Registering runtime services
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IFileSystem
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IAssemblyUtility
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageContainer
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageAssemblyResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IAssemblyResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IScriptHostFactory
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IFilePreProcessor
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IScriptPackResolver
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IInstallationProvider
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IPackageInstaller
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.ScriptServices
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IObjectSerializer
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IConsole
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IFileSystemMigrator
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IScriptLibraryComposer
DEBUG: [ScriptCs.Hosting.ScriptServicesRegistration] Registering default: ScriptCs.Contracts.IVisualStudioSolutionWriter
DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IAssemblyResolver
DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IAssemblyUtility
DEBUG: [ScriptCs.FileSystemMigrator] Not performing migration since directory 'scriptcs_bin' already exists.

DEBUG: [ScriptCs.Hosting.InitializationServices] Resolving IInstallationProvider
DEBUG: [ScriptCs.FileSystemMigrator] Not performing migration since directory 'scriptcs_bin' already exists.

DEBUG: [ScriptCs.AssemblyResolver] Found assembly in bin folder: BuildTool.dll
DEBUG: [ScriptCs.AssemblyResolver] Found assembly in bin folder: ScriptCs.Contracts.dll
DEBUG: [ScriptCs.ScriptExecutor] Initializing script packs
DEBUG: [ScriptCs.FilePreProcessor] Starting pre-processing
DEBUG: [ScriptCs.FilePreProcessor] Processing test.csx...
DEBUG: [ScriptCs.FilePreProcessor] Pre-processing finished successfully
DEBUG: [ScriptCs.ScriptExecutor] Starting execution in engine
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Starting to create execution components
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Creating script host
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Creating session
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Core
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Data
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Data.DataSetExtensions
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Xml
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Xml.Linq
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to System.Net.Http
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to Microsoft.CSharp
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to C:\ProgramData\chocolatey\lib\ScriptCs\tools\ScriptCs.Core.dll
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to C:\ProgramData\chocolatey\lib\ScriptCs\tools\ScriptCs.Contracts.dll
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Adding reference to C:\Users\alist\Source\scriptcs-error\scripts\scriptcs_bin\BuildTool.dll
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Collections.Generic
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Linq
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Text
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Threading.Tasks
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.IO
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Net.Http
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace System.Dynamic
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace BuildTool
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace Microsoft.Build
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace Microsoft.Build.Framework
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace Microsoft.Build.Evaluation
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Importing namespace Microsoft.Build.Execution
DEBUG: [ScriptCs.Engine.Roslyn.CommonScriptEngine] Starting execution
ERROR: [ScriptCs.Command.ExecuteScriptCommand] Script compilation failed. [Microsoft.CodeAnalysis.Scripting.CompilationErrorException] error CS0234: The type or namespace name 'Build' does not exist in the namespace 'Microsoft' (are you missing an assembly reference?)
   at Microsoft.CodeAnalysis.Scripting.Script.CompilationError(DiagnosticBag diagnostics)
   at Microsoft.CodeAnalysis.Scripting.Script.GetExecutor(CancellationToken cancellationToken)
   at Microsoft.CodeAnalysis.Scripting.Script.Run(Object globals)
   at Microsoft.CodeAnalysis.Scripting.Script.Run(Object globals)
   at ScriptCs.Engine.Roslyn.CSharpScriptEngine.GetScriptState(String code, Object globals)
   at ScriptCs.Engine.Roslyn.CommonScriptEngine.Execute(String code, Object globals, SessionState`1 sessionState)
DEBUG: [ScriptCs.ScriptExecutor] Terminating packs
```