using ChainOfInvocationsHW.Elements;
using OpenQA.Selenium;

namespace ChainOfInvocationsHW.Pages.ProjectPages;

public class ProjectsPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/overview";

    // Описание элементов
    private static readonly By TitleLabelBy = By.XPath("//*[contains(@class, 'page_title') and contains(text(), 'Projects')]");
    private static readonly By SuccessMessageBy = By.ClassName("message-success");
    private static readonly By ProjectsTableBy = By.CssSelector("table.grid");

    protected override bool EvaluateLoadedStatus()
    {
        return TitleLabel.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public UIElement TitleLabel => new(Driver, TitleLabelBy);
    public UIElement SuccessMessage => new(Driver, SuccessMessageBy);
    public Table ProjectsTable => new Table(Driver, ProjectsTableBy);
}