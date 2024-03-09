using ChainOfInvocationsHW.Pages.ProjectPages;
using OpenQA.Selenium;
using ChainOfInvocationsHW.Pages;

namespace ChainOfInvocationsHW.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectOverviewPage AddFirstProject(string projectName, string announcement, int projectType)
    {
        return AddProject<ProjectOverviewPage>(projectName, announcement, projectType);
    }

    public ProjectsPage AddAnotherProject(string projectName, string announcement, int projectType)
    {
        return AddProject<ProjectsPage>(projectName, announcement, projectType);
    }

    private T AddProject<T>(string projectName, string announcement, int projectType) where T : BasePage
    {
        AddProjectPage = new AddProjectPage(driver);
        AddProjectPage.NameInput.SendKeys(projectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(projectType);
        AddProjectPage.ShowAnnouncementCheckBox.Click();
        AddProjectPage.AddButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }

    internal string GetProject(string ProjectName)
    {
        ProjectsPage projectsPage = new ProjectsPage(driver);
        string txt = projectsPage.ProjectsTable.GetCell("Project", ProjectName, 0).Text;
        return txt;
    }
}