using OpenQA.Selenium;
using SaucedemoPOMSteps.Core;
using SaucedemoPOMSteps.Helpers;
using SaucedemoPOMSteps.Helpers.Configuration;
using SaucedemoPOMSteps.Steps;

namespace SaucedemoPOMSteps.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected UserSteps UserSteps;

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        UserSteps = new UserSteps(Driver);

        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}