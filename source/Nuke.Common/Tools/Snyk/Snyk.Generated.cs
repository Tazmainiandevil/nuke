// Generated from https://github.com/Tazmainiandevil/nuke/blob/master/source/Nuke.Common/Tools/Snyk/Snyk.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.Snyk;

/// <summary>
///   <p>Snyk is a developer security platform that enables application and cloud developers to secure their whole application � finding and fixing vulnerabilities from their first lines of code to their running cloud.</p>
///   <p>For more details, visit the <a href="https://snyk.io/">official website</a>.</p>
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[PathToolRequirement(SnykPathExecutable)]
public partial class SnykTasks
    : IRequirePathTool
{
    public const string SnykPathExecutable = "snyk";
    /// <summary>
    ///   Path to the Snyk executable.
    /// </summary>
    public static string SnykPath =>
        ToolPathResolver.TryGetEnvironmentExecutable("SNYK_EXE") ??
        ToolPathResolver.GetPathExecutable("snyk");
    public static Action<OutputType, string> SnykLogger { get; set; } = ProcessTasks.DefaultLogger;
    public static Action<ToolSettings, IProcess> SnykExitHandler { get; set; } = ProcessTasks.DefaultExitHandler;
    /// <summary>
    ///   <p>Snyk is a developer security platform that enables application and cloud developers to secure their whole application � finding and fixing vulnerabilities from their first lines of code to their running cloud.</p>
    ///   <p>For more details, visit the <a href="https://snyk.io/">official website</a>.</p>
    /// </summary>
    public static IReadOnlyCollection<Output> Snyk(ArgumentStringHandler arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Action<OutputType, string> logger = null, Action<IProcess> exitHandler = null)
    {
        using var process = ProcessTasks.StartProcess(SnykPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, logger ?? SnykLogger);
        (exitHandler ?? (p => SnykExitHandler.Invoke(null, p))).Invoke(process.AssertWaitForExit());
        return process.Output;
    }
    /// <summary>
    ///   <p>The snyk auth command authenticates your machine to associate the Snyk CLI with your Snyk account</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/auth">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;snykToken&gt;</c> via <see cref="SnykAuthSettings.SnykToken"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykAuth(SnykAuthSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new SnykAuthSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        toolSettings.ProcessExitHandler.Invoke(toolSettings, process.AssertWaitForExit());
        return process.Output;
    }
    /// <summary>
    ///   <p>The snyk auth command authenticates your machine to associate the Snyk CLI with your Snyk account</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/auth">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;snykToken&gt;</c> via <see cref="SnykAuthSettings.SnykToken"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykAuth(Configure<SnykAuthSettings> configurator)
    {
        return SnykAuth(configurator(new SnykAuthSettings()));
    }
    /// <summary>
    ///   <p>The snyk auth command authenticates your machine to associate the Snyk CLI with your Snyk account</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/auth">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>&lt;snykToken&gt;</c> via <see cref="SnykAuthSettings.SnykToken"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(SnykAuthSettings Settings, IReadOnlyCollection<Output> Output)> SnykAuth(CombinatorialConfigure<SnykAuthSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(SnykAuth, SnykLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>The snyk test command checks projects for open-source vulnerabilities and license issues</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykTestSettings.AllProjects"/></li>
    ///     <li><c>--detection-depth</c> via <see cref="SnykTestSettings.DetectionDepth"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykTestSettings.Exclude"/></li>
    ///     <li><c>--fail-on</c> via <see cref="SnykTestSettings.FailOn"/></li>
    ///     <li><c>--file</c> via <see cref="SnykTestSettings.File"/></li>
    ///     <li><c>--org</c> via <see cref="SnykTestSettings.Org"/></li>
    ///     <li><c>--package-manager</c> via <see cref="SnykTestSettings.PackageManager"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykTest(SnykTestSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new SnykTestSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        toolSettings.ProcessExitHandler.Invoke(toolSettings, process.AssertWaitForExit());
        return process.Output;
    }
    /// <summary>
    ///   <p>The snyk test command checks projects for open-source vulnerabilities and license issues</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykTestSettings.AllProjects"/></li>
    ///     <li><c>--detection-depth</c> via <see cref="SnykTestSettings.DetectionDepth"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykTestSettings.Exclude"/></li>
    ///     <li><c>--fail-on</c> via <see cref="SnykTestSettings.FailOn"/></li>
    ///     <li><c>--file</c> via <see cref="SnykTestSettings.File"/></li>
    ///     <li><c>--org</c> via <see cref="SnykTestSettings.Org"/></li>
    ///     <li><c>--package-manager</c> via <see cref="SnykTestSettings.PackageManager"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykTest(Configure<SnykTestSettings> configurator)
    {
        return SnykTest(configurator(new SnykTestSettings()));
    }
    /// <summary>
    ///   <p>The snyk test command checks projects for open-source vulnerabilities and license issues</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykTestSettings.AllProjects"/></li>
    ///     <li><c>--detection-depth</c> via <see cref="SnykTestSettings.DetectionDepth"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykTestSettings.Exclude"/></li>
    ///     <li><c>--fail-on</c> via <see cref="SnykTestSettings.FailOn"/></li>
    ///     <li><c>--file</c> via <see cref="SnykTestSettings.File"/></li>
    ///     <li><c>--org</c> via <see cref="SnykTestSettings.Org"/></li>
    ///     <li><c>--package-manager</c> via <see cref="SnykTestSettings.PackageManager"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(SnykTestSettings Settings, IReadOnlyCollection<Output> Output)> SnykTest(CombinatorialConfigure<SnykTestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(SnykTest, SnykLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>The snyk code test command tests for any known security issues using Static Code Analysis</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/code-test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykCodeTestSettings.AllProjects"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykCodeTestSettings.Exclude"/></li>
    ///     <li><c>--org</c> via <see cref="SnykCodeTestSettings.Org"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykCodeTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykCodeTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykCodeTest(SnykCodeTestSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new SnykCodeTestSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        toolSettings.ProcessExitHandler.Invoke(toolSettings, process.AssertWaitForExit());
        return process.Output;
    }
    /// <summary>
    ///   <p>The snyk code test command tests for any known security issues using Static Code Analysis</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/code-test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykCodeTestSettings.AllProjects"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykCodeTestSettings.Exclude"/></li>
    ///     <li><c>--org</c> via <see cref="SnykCodeTestSettings.Org"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykCodeTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykCodeTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykCodeTest(Configure<SnykCodeTestSettings> configurator)
    {
        return SnykCodeTest(configurator(new SnykCodeTestSettings()));
    }
    /// <summary>
    ///   <p>The snyk code test command tests for any known security issues using Static Code Analysis</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/code-test">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykCodeTestSettings.AllProjects"/></li>
    ///     <li><c>--exclude</c> via <see cref="SnykCodeTestSettings.Exclude"/></li>
    ///     <li><c>--org</c> via <see cref="SnykCodeTestSettings.Org"/></li>
    ///     <li><c>--severity-threshold</c> via <see cref="SnykCodeTestSettings.SeverityThreshold"/></li>
    ///     <li><c>-d</c> via <see cref="SnykCodeTestSettings.Debug"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(SnykCodeTestSettings Settings, IReadOnlyCollection<Output> Output)> SnykCodeTest(CombinatorialConfigure<SnykCodeTestSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(SnykCodeTest, SnykLogger, degreeOfParallelism, completeOnFailure);
    }
    /// <summary>
    ///   <p>The snyk sbom command generates an SBOM for a local software project in an ecosystem supported by Snyk</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/sbom">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykGenerateSbomSettings.AllProjects"/></li>
    ///     <li><c>--format</c> via <see cref="SnykGenerateSbomSettings.Format"/></li>
    ///     <li><c>--json-file-output</c> via <see cref="SnykGenerateSbomSettings.JsonFileOutput"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykGenerateSbom(SnykGenerateSbomSettings toolSettings = null)
    {
        toolSettings = toolSettings ?? new SnykGenerateSbomSettings();
        using var process = ProcessTasks.StartProcess(toolSettings);
        toolSettings.ProcessExitHandler.Invoke(toolSettings, process.AssertWaitForExit());
        return process.Output;
    }
    /// <summary>
    ///   <p>The snyk sbom command generates an SBOM for a local software project in an ecosystem supported by Snyk</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/sbom">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykGenerateSbomSettings.AllProjects"/></li>
    ///     <li><c>--format</c> via <see cref="SnykGenerateSbomSettings.Format"/></li>
    ///     <li><c>--json-file-output</c> via <see cref="SnykGenerateSbomSettings.JsonFileOutput"/></li>
    ///   </ul>
    /// </remarks>
    public static IReadOnlyCollection<Output> SnykGenerateSbom(Configure<SnykGenerateSbomSettings> configurator)
    {
        return SnykGenerateSbom(configurator(new SnykGenerateSbomSettings()));
    }
    /// <summary>
    ///   <p>The snyk sbom command generates an SBOM for a local software project in an ecosystem supported by Snyk</p>
    ///   <p>For more details, visit the <a href="https://docs.snyk.io/snyk-cli/commands/sbom">official website</a>.</p>
    /// </summary>
    /// <remarks>
    ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
    ///   <ul>
    ///     <li><c>--all-projects</c> via <see cref="SnykGenerateSbomSettings.AllProjects"/></li>
    ///     <li><c>--format</c> via <see cref="SnykGenerateSbomSettings.Format"/></li>
    ///     <li><c>--json-file-output</c> via <see cref="SnykGenerateSbomSettings.JsonFileOutput"/></li>
    ///   </ul>
    /// </remarks>
    public static IEnumerable<(SnykGenerateSbomSettings Settings, IReadOnlyCollection<Output> Output)> SnykGenerateSbom(CombinatorialConfigure<SnykGenerateSbomSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
    {
        return configurator.Invoke(SnykGenerateSbom, SnykLogger, degreeOfParallelism, completeOnFailure);
    }
}
#region SnykAuthSettings
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class SnykAuthSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Snyk executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? SnykTasks.SnykPath;
    public override Action<OutputType, string> ProcessLogger => base.ProcessLogger ?? SnykTasks.SnykLogger;
    public override Action<ToolSettings, IProcess> ProcessExitHandler => base.ProcessExitHandler ?? SnykTasks.SnykExitHandler;
    /// <summary>
    ///   The value may be a user token or a service account
    /// </summary>
    public virtual string SnykToken { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("auth")
          .Add("{value}", SnykToken, secret: true);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region SnykTestSettings
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class SnykTestSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Snyk executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? SnykTasks.SnykPath;
    public override Action<OutputType, string> ProcessLogger => base.ProcessLogger ?? SnykTasks.SnykLogger;
    public override Action<ToolSettings, IProcess> ProcessExitHandler => base.ProcessExitHandler ?? SnykTasks.SnykExitHandler;
    /// <summary>
    ///   Auto-detect all projects in the working directory, including Yarn workspaces
    /// </summary>
    public virtual bool? AllProjects { get; internal set; }
    /// <summary>
    ///   Use with --all-projects or --yarn-workspaces to indicate how many subdirectories to search. DEPTH must be a number, 1 or greater; zero (0) is the current directory
    /// </summary>
    public virtual int? DetectionDepth { get; internal set; }
    /// <summary>
    ///   Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path
    /// </summary>
    public virtual string Exclude { get; internal set; }
    /// <summary>
    ///   Report only vulnerabilities at the specified level or higher e.g. critical, high, medium, low
    /// </summary>
    public virtual string SeverityThreshold { get; internal set; }
    /// <summary>
    ///   Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits
    /// </summary>
    public virtual string Org { get; internal set; }
    /// <summary>
    ///   Specify a package file
    /// </summary>
    public virtual string File { get; internal set; }
    /// <summary>
    ///   Specify the name of the package manager when the filename specified with the --file=<FILE> option is not standard. This allows Snyk to find the file
    /// </summary>
    public virtual string PackageManager { get; internal set; }
    /// <summary>
    ///   Fail only when there are vulnerabilities that can be fixed e.g. all,upgradable,patchable
    /// </summary>
    public virtual string FailOn { get; internal set; }
    /// <summary>
    ///   Option to output the debug logs
    /// </summary>
    public virtual bool? Debug { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("test")
          .Add("--all-projects", AllProjects)
          .Add("--detection-depth={value}", DetectionDepth)
          .Add("--exclude={value}", Exclude)
          .Add("--severity-threshold={value}", SeverityThreshold)
          .Add("--org={value}", Org, secret: true)
          .Add("--file={value}", File)
          .Add("--package-manager={value}", PackageManager)
          .Add("--fail-on={value}", FailOn)
          .Add("-d", Debug);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region SnykCodeTestSettings
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class SnykCodeTestSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Snyk executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? SnykTasks.SnykPath;
    public override Action<OutputType, string> ProcessLogger => base.ProcessLogger ?? SnykTasks.SnykLogger;
    public override Action<ToolSettings, IProcess> ProcessExitHandler => base.ProcessExitHandler ?? SnykTasks.SnykExitHandler;
    /// <summary>
    ///   Auto-detect all projects in the working directory, including Yarn workspaces
    /// </summary>
    public virtual bool? AllProjects { get; internal set; }
    /// <summary>
    ///   Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path
    /// </summary>
    public virtual string Exclude { get; internal set; }
    /// <summary>
    ///   Report only vulnerabilities at the specified level or higher e.g. high, medium, low. Note: The Snyk Code configuration issues do not use the critical severity level
    /// </summary>
    public virtual string SeverityThreshold { get; internal set; }
    /// <summary>
    ///   Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits
    /// </summary>
    public virtual string Org { get; internal set; }
    /// <summary>
    ///   Option to output the debug logs
    /// </summary>
    public virtual bool? Debug { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("code test")
          .Add("--all-projects", AllProjects)
          .Add("--exclude={value}", Exclude)
          .Add("--severity-threshold={value}", SeverityThreshold)
          .Add("--org={value}", Org, secret: true)
          .Add("-d", Debug);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region SnykGenerateSbomSettings
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
[Serializable]
public partial class SnykGenerateSbomSettings : ToolSettings
{
    /// <summary>
    ///   Path to the Snyk executable.
    /// </summary>
    public override string ProcessToolPath => base.ProcessToolPath ?? SnykTasks.SnykPath;
    public override Action<OutputType, string> ProcessLogger => base.ProcessLogger ?? SnykTasks.SnykLogger;
    public override Action<ToolSettings, IProcess> ProcessExitHandler => base.ProcessExitHandler ?? SnykTasks.SnykExitHandler;
    /// <summary>
    ///   Auto-detect all projects in the working directory, including Yarn workspaces
    /// </summary>
    public virtual bool? AllProjects { get; internal set; }
    /// <summary>
    ///   Specify the output format for the SBOM to be produced e.g. yclonedx1.4+json, cyclonedx1.4+xml, spdx2.3+json
    /// </summary>
    public virtual string Format { get; internal set; }
    /// <summary>
    ///   Save the SBOM output as a JSON data structure directly to the specified file. This requires the SBOM --format to include +json
    /// </summary>
    public virtual string JsonFileOutput { get; internal set; }
    protected override Arguments ConfigureProcessArguments(Arguments arguments)
    {
        arguments
          .Add("sbom")
          .Add("--all-projects", AllProjects)
          .Add("--format={value}", Format)
          .Add("--json-file-output={value}", JsonFileOutput);
        return base.ConfigureProcessArguments(arguments);
    }
}
#endregion
#region SnykAuthSettingsExtensions
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class SnykAuthSettingsExtensions
{
    #region SnykToken
    /// <summary>
    ///   <p><em>Sets <see cref="SnykAuthSettings.SnykToken"/></em></p>
    ///   <p>The value may be a user token or a service account</p>
    /// </summary>
    [Pure]
    public static T SetSnykToken<T>(this T toolSettings, [Secret] string snykToken) where T : SnykAuthSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SnykToken = snykToken;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykAuthSettings.SnykToken"/></em></p>
    ///   <p>The value may be a user token or a service account</p>
    /// </summary>
    [Pure]
    public static T ResetSnykToken<T>(this T toolSettings) where T : SnykAuthSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SnykToken = null;
        return toolSettings;
    }
    #endregion
}
#endregion
#region SnykTestSettingsExtensions
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class SnykTestSettingsExtensions
{
    #region AllProjects
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T SetAllProjects<T>(this T toolSettings, bool? allProjects) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = allProjects;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ResetAllProjects<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="SnykTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T EnableAllProjects<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="SnykTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T DisableAllProjects<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="SnykTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ToggleAllProjects<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = !toolSettings.AllProjects;
        return toolSettings;
    }
    #endregion
    #region DetectionDepth
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.DetectionDepth"/></em></p>
    ///   <p>Use with --all-projects or --yarn-workspaces to indicate how many subdirectories to search. DEPTH must be a number, 1 or greater; zero (0) is the current directory</p>
    /// </summary>
    [Pure]
    public static T SetDetectionDepth<T>(this T toolSettings, int? detectionDepth) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DetectionDepth = detectionDepth;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.DetectionDepth"/></em></p>
    ///   <p>Use with --all-projects or --yarn-workspaces to indicate how many subdirectories to search. DEPTH must be a number, 1 or greater; zero (0) is the current directory</p>
    /// </summary>
    [Pure]
    public static T ResetDetectionDepth<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.DetectionDepth = null;
        return toolSettings;
    }
    #endregion
    #region Exclude
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.Exclude"/></em></p>
    ///   <p>Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path</p>
    /// </summary>
    [Pure]
    public static T SetExclude<T>(this T toolSettings, string exclude) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Exclude = exclude;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.Exclude"/></em></p>
    ///   <p>Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path</p>
    /// </summary>
    [Pure]
    public static T ResetExclude<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Exclude = null;
        return toolSettings;
    }
    #endregion
    #region SeverityThreshold
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.SeverityThreshold"/></em></p>
    ///   <p>Report only vulnerabilities at the specified level or higher e.g. critical, high, medium, low</p>
    /// </summary>
    [Pure]
    public static T SetSeverityThreshold<T>(this T toolSettings, string severityThreshold) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SeverityThreshold = severityThreshold;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.SeverityThreshold"/></em></p>
    ///   <p>Report only vulnerabilities at the specified level or higher e.g. critical, high, medium, low</p>
    /// </summary>
    [Pure]
    public static T ResetSeverityThreshold<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SeverityThreshold = null;
        return toolSettings;
    }
    #endregion
    #region Org
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.Org"/></em></p>
    ///   <p>Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits</p>
    /// </summary>
    [Pure]
    public static T SetOrg<T>(this T toolSettings, [Secret] string org) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Org = org;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.Org"/></em></p>
    ///   <p>Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits</p>
    /// </summary>
    [Pure]
    public static T ResetOrg<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Org = null;
        return toolSettings;
    }
    #endregion
    #region File
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.File"/></em></p>
    ///   <p>Specify a package file</p>
    /// </summary>
    [Pure]
    public static T SetFile<T>(this T toolSettings, string file) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = file;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.File"/></em></p>
    ///   <p>Specify a package file</p>
    /// </summary>
    [Pure]
    public static T ResetFile<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.File = null;
        return toolSettings;
    }
    #endregion
    #region PackageManager
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.PackageManager"/></em></p>
    ///   <p>Specify the name of the package manager when the filename specified with the --file=<FILE> option is not standard. This allows Snyk to find the file</p>
    /// </summary>
    [Pure]
    public static T SetPackageManager<T>(this T toolSettings, string packageManager) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PackageManager = packageManager;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.PackageManager"/></em></p>
    ///   <p>Specify the name of the package manager when the filename specified with the --file=<FILE> option is not standard. This allows Snyk to find the file</p>
    /// </summary>
    [Pure]
    public static T ResetPackageManager<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.PackageManager = null;
        return toolSettings;
    }
    #endregion
    #region FailOn
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.FailOn"/></em></p>
    ///   <p>Fail only when there are vulnerabilities that can be fixed e.g. all,upgradable,patchable</p>
    /// </summary>
    [Pure]
    public static T SetFailOn<T>(this T toolSettings, string failOn) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.FailOn = failOn;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.FailOn"/></em></p>
    ///   <p>Fail only when there are vulnerabilities that can be fixed e.g. all,upgradable,patchable</p>
    /// </summary>
    [Pure]
    public static T ResetFailOn<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.FailOn = null;
        return toolSettings;
    }
    #endregion
    #region Debug
    /// <summary>
    ///   <p><em>Sets <see cref="SnykTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T SetDebug<T>(this T toolSettings, bool? debug) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = debug;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T ResetDebug<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="SnykTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T EnableDebug<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="SnykTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T DisableDebug<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="SnykTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T ToggleDebug<T>(this T toolSettings) where T : SnykTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = !toolSettings.Debug;
        return toolSettings;
    }
    #endregion
}
#endregion
#region SnykCodeTestSettingsExtensions
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class SnykCodeTestSettingsExtensions
{
    #region AllProjects
    /// <summary>
    ///   <p><em>Sets <see cref="SnykCodeTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T SetAllProjects<T>(this T toolSettings, bool? allProjects) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = allProjects;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykCodeTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ResetAllProjects<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="SnykCodeTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T EnableAllProjects<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="SnykCodeTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T DisableAllProjects<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="SnykCodeTestSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ToggleAllProjects<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = !toolSettings.AllProjects;
        return toolSettings;
    }
    #endregion
    #region Exclude
    /// <summary>
    ///   <p><em>Sets <see cref="SnykCodeTestSettings.Exclude"/></em></p>
    ///   <p>Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path</p>
    /// </summary>
    [Pure]
    public static T SetExclude<T>(this T toolSettings, string exclude) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Exclude = exclude;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykCodeTestSettings.Exclude"/></em></p>
    ///   <p>Can be used with --all-projects and --yarn-workspaces to indicate directory names and file names to exclude. Must be comma-separated, and cannot include a path</p>
    /// </summary>
    [Pure]
    public static T ResetExclude<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Exclude = null;
        return toolSettings;
    }
    #endregion
    #region SeverityThreshold
    /// <summary>
    ///   <p><em>Sets <see cref="SnykCodeTestSettings.SeverityThreshold"/></em></p>
    ///   <p>Report only vulnerabilities at the specified level or higher e.g. high, medium, low. Note: The Snyk Code configuration issues do not use the critical severity level</p>
    /// </summary>
    [Pure]
    public static T SetSeverityThreshold<T>(this T toolSettings, string severityThreshold) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SeverityThreshold = severityThreshold;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykCodeTestSettings.SeverityThreshold"/></em></p>
    ///   <p>Report only vulnerabilities at the specified level or higher e.g. high, medium, low. Note: The Snyk Code configuration issues do not use the critical severity level</p>
    /// </summary>
    [Pure]
    public static T ResetSeverityThreshold<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.SeverityThreshold = null;
        return toolSettings;
    }
    #endregion
    #region Org
    /// <summary>
    ///   <p><em>Sets <see cref="SnykCodeTestSettings.Org"/></em></p>
    ///   <p>Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits</p>
    /// </summary>
    [Pure]
    public static T SetOrg<T>(this T toolSettings, [Secret] string org) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Org = org;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykCodeTestSettings.Org"/></em></p>
    ///   <p>Specify the <ORG_ID>to run Snyk commands tied to a specific Snyk Organization. The <ORG_ID> influences private test limits</p>
    /// </summary>
    [Pure]
    public static T ResetOrg<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Org = null;
        return toolSettings;
    }
    #endregion
    #region Debug
    /// <summary>
    ///   <p><em>Sets <see cref="SnykCodeTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T SetDebug<T>(this T toolSettings, bool? debug) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = debug;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykCodeTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T ResetDebug<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="SnykCodeTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T EnableDebug<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="SnykCodeTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T DisableDebug<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="SnykCodeTestSettings.Debug"/></em></p>
    ///   <p>Option to output the debug logs</p>
    /// </summary>
    [Pure]
    public static T ToggleDebug<T>(this T toolSettings) where T : SnykCodeTestSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Debug = !toolSettings.Debug;
        return toolSettings;
    }
    #endregion
}
#endregion
#region SnykGenerateSbomSettingsExtensions
/// <summary>
///   Used within <see cref="SnykTasks"/>.
/// </summary>
[PublicAPI]
[ExcludeFromCodeCoverage]
public static partial class SnykGenerateSbomSettingsExtensions
{
    #region AllProjects
    /// <summary>
    ///   <p><em>Sets <see cref="SnykGenerateSbomSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T SetAllProjects<T>(this T toolSettings, bool? allProjects) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = allProjects;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykGenerateSbomSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ResetAllProjects<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = null;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Enables <see cref="SnykGenerateSbomSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T EnableAllProjects<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = true;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Disables <see cref="SnykGenerateSbomSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T DisableAllProjects<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = false;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Toggles <see cref="SnykGenerateSbomSettings.AllProjects"/></em></p>
    ///   <p>Auto-detect all projects in the working directory, including Yarn workspaces</p>
    /// </summary>
    [Pure]
    public static T ToggleAllProjects<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.AllProjects = !toolSettings.AllProjects;
        return toolSettings;
    }
    #endregion
    #region Format
    /// <summary>
    ///   <p><em>Sets <see cref="SnykGenerateSbomSettings.Format"/></em></p>
    ///   <p>Specify the output format for the SBOM to be produced e.g. yclonedx1.4+json, cyclonedx1.4+xml, spdx2.3+json</p>
    /// </summary>
    [Pure]
    public static T SetFormat<T>(this T toolSettings, string format) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Format = format;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykGenerateSbomSettings.Format"/></em></p>
    ///   <p>Specify the output format for the SBOM to be produced e.g. yclonedx1.4+json, cyclonedx1.4+xml, spdx2.3+json</p>
    /// </summary>
    [Pure]
    public static T ResetFormat<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.Format = null;
        return toolSettings;
    }
    #endregion
    #region JsonFileOutput
    /// <summary>
    ///   <p><em>Sets <see cref="SnykGenerateSbomSettings.JsonFileOutput"/></em></p>
    ///   <p>Save the SBOM output as a JSON data structure directly to the specified file. This requires the SBOM --format to include +json</p>
    /// </summary>
    [Pure]
    public static T SetJsonFileOutput<T>(this T toolSettings, string jsonFileOutput) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.JsonFileOutput = jsonFileOutput;
        return toolSettings;
    }
    /// <summary>
    ///   <p><em>Resets <see cref="SnykGenerateSbomSettings.JsonFileOutput"/></em></p>
    ///   <p>Save the SBOM output as a JSON data structure directly to the specified file. This requires the SBOM --format to include +json</p>
    /// </summary>
    [Pure]
    public static T ResetJsonFileOutput<T>(this T toolSettings) where T : SnykGenerateSbomSettings
    {
        toolSettings = toolSettings.NewInstance();
        toolSettings.JsonFileOutput = null;
        return toolSettings;
    }
    #endregion
}
#endregion
