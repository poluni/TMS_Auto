using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.ProjectTestCase;

public class ProjectTestCaseDetailsPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By OverviewTabBy = By.XPath("//table[@class='io']");
    private static readonly By SuccessMessageTextBy = By.XPath("//div[@class='message message-success']");
    private static readonly By TestCaseMenuBy = By.Id("navigation-suites");

    protected override bool EvaluateLoadedStatus()
    {
        return OverviewTab.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public string GetSuccessMessageText()
    {
        return SuccessMessageText.Text.Trim();
    }


    public void TestCaseMenuClick()
    {
        TestCaseMenu.Click();
    }

    protected UIElement OverviewTab => new(Driver, OverviewTabBy);
    protected UIElement SuccessMessageText => new(Driver, SuccessMessageTextBy);
    protected UIElement TestCaseMenu => new(Driver, TestCaseMenuBy);
}