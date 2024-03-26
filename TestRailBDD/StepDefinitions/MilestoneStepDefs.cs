using TestRailCore.Core;
using TestRailCore.Pages;
using NUnit.Framework;
using TestRailCore.Steps;
using TestRailCore.Models;
using TestRailCore.Pages.MilestonePages;

namespace TestRailBDD.StepDefinitions;

[Binding]
public sealed class MilestoneStepDefs : BaseSteps
{
    private readonly ProjectMilestonesPage _projectMilestonesPage;
    private MilestoneSteps _milestoneSteps;
    private Milestone TestMilestone { get; set; }

    public MilestoneStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _milestoneSteps = new MilestoneSteps(Driver);
        _projectMilestonesPage = new ProjectMilestonesPage(Driver);
    }


    [When(@"the user deleted milestone")]
    public void DeleteMilestone()
    {
        _milestoneSteps.DeleteProjectMilestone();
    }

    [When(@"filled the milestone data")]
    public void AddFirstMilestone()
    {
        TestMilestone = new Milestone
        {
            Name = "TestName" + new Random().Next().ToString(),
            Description = "TestDescription1"
        };

        _milestoneSteps.AddFirstProjectMilestone(TestMilestone);
    }

    [When(@"changed milestone title")]
    public void EditMilestone()
    {
        TestMilestone = new Milestone
        {
            Name = "TestName" + new Random().Next().ToString()
        };

        _milestoneSteps.EditProjectMilestoneTitle(TestMilestone);
    }

    [Then(@"a success added message was displayed")]
    public void IsSuccessAddedMessageDisplayed()
    {
        Assert.That(_projectMilestonesPage.GetSuccessMessageText()
                 .Equals("Successfully added the new milestone."));
    }

    [Then(@"a success updated message was displayed")]
    public void IsSuccessUpdatedMessageDisplayed()
    {
        Assert.That(_projectMilestonesPage.GetSuccessMessageText()
                 .Equals("Successfully updated the milestone."));
    }

    [Then(@"a success deleted message was displayed")]
    public void IsDeletedUpdatedMessageDisplayed()
    {
        Assert.That(_projectMilestonesPage.GetSuccessMessageText()
                 .Equals("Successfully deleted the milestone (s)."));
    }
}