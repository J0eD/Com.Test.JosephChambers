// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using System.Diagnostics;
using global::NUnit.Framework;
using global::TechTalk.SpecFlow;
using global::System.Runtime.CompilerServices;

[GeneratedCode("SpecFlow", "3.8.14")]
[SetUpFixture]
public class Com_Test_JosephC_NUnitAssemblyHooks
{
    [OneTimeSetUp]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyInitialize()
    {
        var currentAssembly = typeof(Com_Test_JosephC_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunStart(currentAssembly);
    }

    [OneTimeTearDown]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssemblyCleanup()
    {
        var currentAssembly = typeof(Com_Test_JosephC_NUnitAssemblyHooks).Assembly;

        TestRunnerManager.OnTestRunEnd(currentAssembly);
    }
}
#pragma warning restore
