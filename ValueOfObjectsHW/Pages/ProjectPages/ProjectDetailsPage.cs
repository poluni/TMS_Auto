using OpenQA.Selenium;
using ValueOfObjectsHW.Elements;
using ValueOfObjectsHW.Pages;

namespace ValueOfObjectsHW.Pages.ProjectPages;

public class ProjectDetailsPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By OverviewTabBy = By.Id("navigation-projects");


    protected override bool EvaluateLoadedStatus()
    {
        return OverviewTab.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public UIElement OverviewTab => new(Driver, OverviewTabBy);
}