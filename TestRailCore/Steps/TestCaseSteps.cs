using TestRailCore.Models;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;
using TestRailCore.Pages.TestCasePages;
using OpenQA.Selenium;
using TestRailCore.Pages.MilestonePages;
using TestRailCore.Pages.ProjectTestCase;

namespace TestRailCore.Steps;

public class TestCaseSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectTestCaseDetailsPage EditProjectTestCaseTitle(TestCase testcase)
    {
        EditProjectTestCasesPage = new EditProjectTestCasesPage(driver);

        EditProjectTestCasesPage.NameTestCaseInput.Clear();
        EditProjectTestCasesPage.NameTestCaseInput.SendKeys(testcase.Title);
        EditProjectTestCasesPage.SaveButton.Click();

        return new ProjectTestCaseDetailsPage(driver);
    }

    public ProjectTestCasesPage DeleteProjectTestCase()
    {
        ProjectTestCasesPage = new ProjectTestCasesPage(driver);

        ProjectTestCasesPage.SelectTestCaseForEditClick();
        ProjectTestCasesPage.DeleteTestCaseLinkClick();
        ProjectTestCasesPage.DeleteTestCasePermanently();
        ProjectTestCasesPage.DeleteTestCase();

        return new ProjectTestCasesPage(driver);
    }

    public ProjectTestCaseDetailsPage AddSuccssesfullTestCase(TestCase testcase)
    {
        return AddTestCase<ProjectTestCaseDetailsPage>(testcase);
    }

    public int GetCountTestCases()
    {
        ProjectTestCasesPage = new ProjectTestCasesPage(driver);

        return Int32.Parse(ProjectTestCasesPage.CountTestCaseText());
    }

    private T AddTestCase<T>(TestCase testcase) where T : BasePage
    {
        AddProjectTestCasesPage = new AddProjectTestCasesPage(driver);

        AddProjectTestCasesPage.NameTestCaseInput.SendKeys(testcase.Title);
        AddProjectTestCasesPage.AddButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}