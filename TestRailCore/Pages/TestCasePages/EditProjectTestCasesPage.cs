using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.TestCasePages;

public class EditProjectTestCasesPage(IWebDriver? driver, bool openByURL = false) : ProjectTestCasesBasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(SaveButtonBy).Displayed;
    }

    // Атомарные Методы
    internal Button SaveButton => new Button(Driver, SaveButtonBy);
}