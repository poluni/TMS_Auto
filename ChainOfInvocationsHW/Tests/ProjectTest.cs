using ChainOfInvocationsHW.Pages;
using System.Collections;

namespace ChainOfInvocationsHW.Tests;

public class ProjectTest : BaseLoginTest
{
    private static readonly string s_projectName = "Test Project" + new Random().Next().ToString();
    private static readonly string s_announcement = "Test Details" + new Random().Next().ToString();
    private static readonly int s_projectType = new Random().Next(0, 3);

    [Order(1)]
    [Test]
    public void SuccessfullAddFirstProjectTest()
    {
        new DashboardPage(Driver).AddProjectClick();

        _projectsSteps.AddFirstProject(s_projectName, s_announcement, s_projectType);

        Assert.That(new ProjectOverviewPage(Driver).isFirstProjectAdded);

    }

    [Order(2)]
    [Test]
    public void SuccessfullAddProjectTest()
    {
        new DashboardPage(Driver).AddProjectClick();

        _projectsSteps.AddAnotherProject(s_projectName, s_announcement, s_projectType);

        Assert.That(_projectsSteps.GetProject(s_projectName),
            Is.EqualTo(s_projectName));
    }
}