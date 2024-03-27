using TestRailCore.Models;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;
using TestRailCore.Pages.MilestonePages;
using OpenQA.Selenium;
using TestRailCore.Pages.TestCasePages;
using TestRailCore.Pages.ProjectTestCase;

namespace TestRailCore.Steps;

public class NavigationSteps : BaseStep
{
    private readonly ProjectOverviewPage _projectOverviewPage;
    private readonly LoginPage _loginPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }

    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver, true);
    }

    public DashboardPage NavigateToDashboardPage()
    {
        return new DashboardPage(Driver);
    }

    public AddProjectPage NavigateToAddProjectPage()
    {
        return new AddProjectPage(Driver);
    }

    public AddMilestonePage NavigateToAddMilestonePage()
    {
        ProjectMilestonesPage = new ProjectMilestonesPage(Driver);
        ProjectMilestonesPage.AddMilestoneLinkClick();

        return new AddMilestonePage(Driver);
    }

    public AddProjectTestCasesPage NavigateToAddTestCasePage()
    {
        ProjectTestCasesPage = new ProjectTestCasesPage(Driver);
        ProjectTestCasesPage.AddTestCaseLink.Click();

        return new AddProjectTestCasesPage(Driver);
    }

    public ProjectTestCasesPage NavigateToProjectMilestonesPage()
    {
        ProjectOverviewPage = new ProjectOverviewPage(Driver);
        ProjectOverviewPage.MilestonesMenuClick();

        return new ProjectTestCasesPage(Driver);
    }

    public ProjectTestCasesPage NavigateToProjectTestCasesPage()
    {
        ProjectTestCaseDetailsPage = new ProjectTestCaseDetailsPage(Driver);
        ProjectTestCaseDetailsPage.TestCaseMenuClick();

        return new ProjectTestCasesPage(Driver);
    }

    public ProjectTestCasesPage NavigateToProjectTestCasesMenuPage()
    {
        DashboardPage = new DashboardPage(Driver);
        DashboardPage.GoToProjectTestCasesClick();

        return new ProjectTestCasesPage(Driver);
    }

    public EditMilestonePage NavigateToEditMilestonesPage()
    {
        ProjectMilestonesPage = new ProjectMilestonesPage(Driver);
        ProjectMilestonesPage.EditProjectMilestoneClick();

        return new EditMilestonePage(Driver);
    }

    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }

    public T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(Driver);

        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}