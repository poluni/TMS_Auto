using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.TestCasePages;

public abstract class ProjectTestCasesBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private static readonly By NameTestCaseInputBy = By.Id("title");

    // Атомарные Методы
    internal UIElement NameTestCaseInput => new(Driver, NameTestCaseInputBy);
}