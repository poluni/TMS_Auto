using SaucedemoCore.Helpers.Configuration;
using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using NUnit.Framework;
using SaucedemoCore.Pages;
using OpenQA.Selenium;

namespace SaucedemoBDDv2.Hooks;

[Binding]
public class Hooks
{
    private readonly Browser _browser;

    public Hooks(Browser browser)
    {
        _browser = browser;
    }

    [BeforeScenario("GUI")]
    public void BeforeGUIScenario()
    {
        _browser.SetUpDriver();
        _browser.Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [AfterScenario("GUI")]
    public void AfterScenario()
    {
        _browser.Driver.Quit();
    }
}