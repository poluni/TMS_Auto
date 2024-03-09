using OpenQA.Selenium;
using ValueOfObjectsHW.Pages;
using ValueOfObjectsHW.Pages.ProjectPages;
using ValueOfObjectsHW.Models;

namespace ValueOfObjectsHW.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectOverviewPage AddFirstProject(Project project)
    {
        return AddProject<ProjectOverviewPage>(project);
    }

    public ProjectsPage AddAnotherProject(Project project)
    {
        return AddProject<ProjectsPage>(project);
    }

    private T AddProject<T>(Project project) where T : BasePage
    {
        AddProjectPage = new AddProjectPage(driver);
        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        AddProjectPage.ShowAnnouncementCheckBox.Click();
        AddProjectPage.AddButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }

    internal string GetProject(Project projectToFind)
    {
        ProjectsPage projectsPage = new ProjectsPage(driver);
        string txt = projectsPage.ProjectsTable.GetCell("Project", projectToFind.ProjectName, 0).Text;
        return txt;
    }
}