using TestRailCore.Core;
using TestRailCore.Pages;

namespace TestRailBDD.StepDefinitions;

[Binding]
public sealed class ProjectStepDefs : BaseSteps
{
    private readonly DashboardPage _dashboardPage;

    public ProjectStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _dashboardPage = new DashboardPage(Driver);
    }

    [Given(@"The user navigated to the project milestones")]
    public void GoToProjectMilestones()
    {
        _dashboardPage.GoToProjectMilestonesClick();
    }

    [Given(@"The user navigated to the project test cases")]
    public void GoToProjectTestCases()
    {
        _dashboardPage.GoToProjectTestCasesClick();
    }
}