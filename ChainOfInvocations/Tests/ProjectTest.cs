using ChainOfInvocationsHW.Pages;
using ChainOfInvocationsHW.Pages.ProjectPages;
using ChainOfInvocationsHW.Steps;
using ChainOfInvocationsHW.Helpers.Configuration;
using ChainOfInvocationsHW.Models;

namespace ChainOfInvocationsHW.Tests;

public class ProjectTest : BaseLoginTest
{
    [Test, Order(1)]
    public void SuccessfullAddFirstProjectTest()
    {
        new DashboardPage(Driver).AddProjectClick();

        Project expectedProject = new Project().GenerateProject();

        _projectsSteps.AddFirstProject(expectedProject);

        Assert.That(new ProjectOverviewPage(Driver).isFirstProjectAdded);

    }

    [Test, Order(2)]
    public void SuccessfullAddProjectTest()
    {
        new DashboardPage(Driver).AddProjectClick();

        Project expectedProject = new Project().GenerateProject();

        _projectsSteps.AddAnotherProject(expectedProject);

        Assert.That(_projectsSteps.GetProject(expectedProject),
            Is.EqualTo(expectedProject.ProjectName));
    }
}