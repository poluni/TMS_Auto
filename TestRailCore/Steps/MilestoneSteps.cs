using TestRailCore.Models;
using TestRailCore.Pages;
using OpenQA.Selenium;
using TestRailCore.Pages.MilestonePages;

namespace TestRailCore.Steps;

public class MilestoneSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectMilestonesPage EditProjectMilestoneTitle(Milestone milestone)
    {
        EditMilestonePage = new EditMilestonePage(driver);

        EditMilestonePage.NameMileston.Clear();
        EditMilestonePage.NameMileston.SendKeys(milestone.Name);
        EditMilestonePage.EditMilestone.Click();

        return new ProjectMilestonesPage(driver);
    }

    public ProjectMilestonesPage DeleteProjectMilestone()
    {
        ProjectMilestonesPage = new ProjectMilestonesPage(driver);

        ProjectMilestonesPage.SelectMilestoneForDeleteClick();
        ProjectMilestonesPage.DeleteLinkClick();
        ProjectMilestonesPage.SelectConfirmationForDeleteCheckbox();
        ProjectMilestonesPage.DeleteButtonClick();

        return new ProjectMilestonesPage(driver);
    }

    public ProjectMilestonesPage AddFirstProjectMilestone(Milestone milestone)
    {
        return AddMilestone<ProjectMilestonesPage>(milestone);
    }

    private T AddMilestone<T>(Milestone milestone) where T : BasePage
    {
        AddMilestonePage = new AddMilestonePage(driver);

        AddMilestonePage.NameMileston.SendKeys(milestone.Name);
        AddMilestonePage.DescriptionTextArea.SendKeys(milestone.Description);
        AddMilestonePage.AddMilestoneButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}