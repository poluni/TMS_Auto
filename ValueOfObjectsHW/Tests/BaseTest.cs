using OpenQA.Selenium;
using ValueOfObjectsHW.Core;
using ValueOfObjectsHW.Helpers;
using ValueOfObjectsHW.Helpers.Configuration;
using ValueOfObjectsHW.Models;
using ValueOfObjectsHW.Steps;

namespace ValueOfObjectsHW.Tests;

//[Parallelizable(scope: ParallelScope.All)]
//[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectsSteps _projectsSteps;

    protected User Admin { get; private set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        _navigationSteps = new NavigationSteps(Driver);
        _projectsSteps = new ProjectsSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}