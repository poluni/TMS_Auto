using OpenQA.Selenium;
using ChainOfInvocationsHW.Core;
using ChainOfInvocationsHW.Steps;
using ChainOfInvocationsHW.Helpers;
using ChainOfInvocationsHW.Helpers.Configuration;

namespace ChainOfInvocationsHW.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectsSteps _projectsSteps;

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        _navigationSteps = new NavigationSteps(Driver);
        _projectsSteps = new ProjectsSteps(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}