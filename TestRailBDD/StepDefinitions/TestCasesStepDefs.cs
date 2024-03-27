using TestRailCore.Core;
using TestRailCore.Steps;
using TestRailCore.Helpers.Configuration;
using TestRailCore.Pages;
using TestRailCore.Models;
using NUnit.Framework;
using TestRailCore.Pages.MilestonePages;
using TestRailCore.Pages.TestCasePages;
using TestRailCore.Pages.ProjectTestCase;

namespace TestRailBDD.StepDefinitions;

[Binding]
public sealed class TestCasesStepDefs : BaseSteps
{

    private ProjectTestCasesPage _projectTestCasesPage;
    private ProjectTestCaseDetailsPage _projectTestCaseDetailsPage;
    private TestCaseSteps _testCaseSteps;
    private TestCase TestCaseData { get; set; }
    private int cntBefore;

    public TestCasesStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _testCaseSteps = new TestCaseSteps(Driver);
        _projectTestCasesPage = new ProjectTestCasesPage(Driver);
        _projectTestCaseDetailsPage = new ProjectTestCaseDetailsPage(Driver);
    }

    [When(@"filled the test case data: (.*)")]
    public void AddFirstTestCase(string name)
    {
        TestCaseData = new TestCase
        {
            Title = name
        };

        _testCaseSteps.AddSuccssesfullTestCase(TestCaseData);
    }

    [When(@"The user selected test case")]
    public void SelectTestCase()
    {
        _projectTestCasesPage.SelectTestCaseForEditClick();
    }

    [When(@"the user clicked Edit test case")]
    public void EditTestCase()
    {
        _projectTestCasesPage.EditLinkClick();
    }

    [When(@"changed test case title")]
    public void EditTestCaseTitle()
    {
        TestCaseData = new TestCase
        {
            Title = "TestName" + new Random().Next().ToString()
        };

        _testCaseSteps.EditProjectTestCaseTitle(TestCaseData);
    }

    [When(@"the user deleted test case")]
    public void DeleteTestCase()
    {
        cntBefore = _testCaseSteps.GetCountTestCases();
        _testCaseSteps.DeleteProjectTestCase();
    }

    [Then(@"a success test case added message was displayed")]
    public void IsSuccessAddedMessageDisplayed()
    {
        Assert.That(_projectTestCaseDetailsPage.GetSuccessMessageText()
                 .Equals("Successfully added the new test case. Add another"));
    }

    [Then(@"a success test case updated message was displayed")]
    public void IsSuccessUpdatedMessageDisplayed()
    {
        Assert.That(_projectTestCaseDetailsPage.GetSuccessMessageText()
                 .Equals("Successfully updated the test case."));
    }

    [Then(@"a test case was deleted")]
    public void IsTestCaseDeleted()
    {
        Assert.That(_testCaseSteps.GetCountTestCases()
               .Equals(cntBefore - 1));
    }
}