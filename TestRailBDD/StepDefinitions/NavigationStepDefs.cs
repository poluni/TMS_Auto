using TestRailCore.Core;
using TestRailCore.Steps;
using TestRailCore.Helpers.Configuration;
using TestRailCore.Models;

namespace TestRailBDD.StepDefinitions;

[Binding]
public sealed class NavigationStepDefs : BaseSteps
{
    private NavigationSteps _navigationSteps;
    private User Admin { get; set; }

    public NavigationStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
    }

    [Given(@"The user entered the admin login and password")]
    public void SuccessfulLogin()
    {
        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };

        _navigationSteps.SuccessfulLogin(Admin);
    }

    [When(@"The user added the milestone")]
    public void AddFirstMilestone()
    {
        _navigationSteps.NavigateToAddMilestonePage();
    }

    [When(@"The user clicked Milestones menu")]
    public void NavigateToMilestonesMenu()
    {
        _navigationSteps.NavigateToProjectMilestonesPage();
    }

    [When(@"The user clicked Add test case")]
    public void AddTestCasesClick()
    {
        _navigationSteps.NavigateToAddTestCasePage();
    }

    [When(@"The user clicked TestCases menu")]
    public void NavigateToTestCasesMenu()
    {
        _navigationSteps.NavigateToProjectTestCasesMenuPage();
    }

    [When(@"the user clicked Edit milestone")]
    public void EditMilestoneClick()
    {
        _navigationSteps.NavigateToEditMilestonesPage();
    }

    [When(@"The user navigated to the project test cases")]
    public void NavigateToTestCases()
    {
        _navigationSteps.NavigateToProjectTestCasesPage();
    }
}