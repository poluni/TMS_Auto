using TestRailCore.Models;
using TestRailCore.Pages.ProjectPages;
using OpenQA.Selenium;

namespace TestRailCore.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddAnotherProject(string projectName, string announcement)
    {
        AddProjectPage = new AddProjectPage(driver);
        AddProjectPage.NameInput.SendKeys(projectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(announcement);
        AddProjectPage.AddButton.Click();

        return new ProjectsPage(driver);
    }

    internal string GetProject(Project projectToFind)
    {
        ProjectsPage projectsPage = new ProjectsPage(driver);
        string txt = projectsPage.ProjectsTable.GetCell("Project", projectToFind.ProjectName, 0).Text;
        return txt;
    }
}