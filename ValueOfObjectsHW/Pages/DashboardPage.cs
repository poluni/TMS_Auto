using ValueOfObjectsHW.Pages.ProjectPages;
using OpenQA.Selenium;
using ValueOfObjectsHW.Elements;

namespace ValueOfObjectsHW.Pages;

public class DashboardPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/dashboard";

    // Описание элементов
    private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");
    private static readonly By TitleLabelBy = By.ClassName("page_title");
    private static readonly By AddFirstProjectTextBy = By.ClassName("empty-title");


    protected override bool EvaluateLoadedStatus()
    {
        try
        {
            return SidebarProjectsAddButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public bool IsPageOpened()
    {
        return TitleLabel.Displayed;
    }

    public string GetAddFirstProjectText()
    {
        return AddFirstProjectText.Text;
    }

    public bool IsFirstProject()
    {
        return GetAddFirstProjectText().Equals("Add your first project to TestRail");
    }

    public void AddProjectClick()
    {
        SidebarProjectsAddButton.Click();
    }

    public Button SidebarProjectsAddButton => new Button(Driver, SidebarProjectsAddButtonBy);
    protected UIElement TitleLabel => new(Driver, TitleLabelBy);
    protected UIElement AddFirstProjectText => new(Driver, AddFirstProjectTextBy);
}