using TestRailCore.Core;
using OpenQA.Selenium;

namespace TestRailBDD.StepDefinitions;

public class BaseSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext ScenarioContext { get; }

    public BaseSteps(Browser browser, ScenarioContext scenarioContext)
    {
        Driver = browser.Driver;
        ScenarioContext = scenarioContext;
    }
}