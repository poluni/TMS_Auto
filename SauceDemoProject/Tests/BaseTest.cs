using OpenQA.Selenium;
using SauceDemoProject.Core;

namespace SauceDemoProject.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }

    [SetUp]
    public void FactoryDriverTest()
    {
        Driver = new Browser().Driver;
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }

}