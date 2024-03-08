using ChainOfInvocationsHW.Pages;
using ChainOfInvocationsHW.Pages.ProjectPages;
using OpenQA.Selenium;

namespace ChainOfInvocationsHW.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
    protected ProjectsPage? ProjectsPage { get; set; }
    protected ProjectOverviewPage? ProjectOverviewPage { get; set; }
}