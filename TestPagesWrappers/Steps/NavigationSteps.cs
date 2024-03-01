using OpenQA.Selenium;
using TestPagesWrappers.Pages;
using TestPagesWrappers.Helpers.Configuration;

namespace TestPagesWrappers.Steps;

public class NavigationSteps : BaseSteps
{
    private FormPage _formPage;
    private TablePage _tablePage;
    private MenuPage _menuPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _menuPage = new MenuPage(driver);
        _formPage = new FormPage(driver);
        _tablePage = new TablePage(driver);
    }

    public FormPage NavigateToForms()
    {
        _menuPage.FormFieldsLink.Click();
        return new FormPage(Driver);
    }

    public TablePage NavigateToTables()
    {
        _menuPage.TablesLink.Click();
        return new TablePage(Driver);
    }
}