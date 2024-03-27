using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.ProjectPages;

public class ProjectsPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/overview";
        
    // Описание элементов
    private static readonly By TitleBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    private static readonly By ProjectsTableBy = By.CssSelector("table.grid");

    protected override bool EvaluateLoadedStatus()
    {
        return Title.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected UIElement Title => new(Driver, TitleBy);
    protected UIElement SuccessMessage => new(Driver, SuccessMessageBy);
    internal Table ProjectsTable => new Table(Driver, ProjectsTableBy);
}