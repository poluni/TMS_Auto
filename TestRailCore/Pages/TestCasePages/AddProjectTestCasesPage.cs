using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.TestCasePages;

public class AddProjectTestCasesPage(IWebDriver? driver, bool openByURL = false) : ProjectTestCasesBasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By AddButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddButtonBy).Displayed;
    }

    // Атомарные Методы
    internal Button AddButton => new Button(Driver, AddButtonBy);
}