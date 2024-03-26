using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;
using TestRailCore.Pages.MilestonePages;
using OpenQA.Selenium;
using TestRailCore.Pages.TestCasePages;
using TestRailCore.Pages.ProjectTestCase;

namespace TestRailCore.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }

    protected AddProjectPage? AddProjectPage { get; set; }
    protected ProjectOverviewPage? ProjectOverviewPage { get; set; }    
    protected ProjectsPage? ProjectsPage { get; set; }

    protected AddMilestonePage? AddMilestonePage { get; set; }
    protected ProjectMilestonesPage? ProjectMilestonesPage { get; set; }
    protected EditMilestonePage? EditMilestonePage { get; set; }

    protected ProjectTestCasesPage? ProjectTestCasesPage { get; set; }
    protected ProjectTestCaseDetailsPage? ProjectTestCaseDetailsPage { get; set; }
    protected AddProjectTestCasesPage? AddProjectTestCasesPage { get; set; }
    protected EditProjectTestCasesPage? EditProjectTestCasesPage { get; set; }


}