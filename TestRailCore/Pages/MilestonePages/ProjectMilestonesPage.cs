using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.MilestonePages;

public class ProjectMilestonesPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By EditProjectMilestoneLinkBy = By.XPath("//a[contains(text(),'Edit') and @class='link']");
    private static readonly By MilestoneForDeleteCheckboxBy = By.XPath("//input[@name='entity_milestones']");
    private static readonly By DeleteLinkBy = By.XPath("//span[@id='delete-milestones']/a");
    private static readonly By ConfirmationForDeleteCheckboxBy = By.Id("confirm-check");
    private static readonly By ConfirmationWindowBy = By.XPath("//span[@class='ui-dialog-title']");
    private static readonly By DeleteButtonBy = By.XPath("//div[@id='bulkDeleteDialog']//a[contains(text(),'Delete')]");
    private static readonly By SuccessMessageTextBy = By.XPath("//div[@class='message message-success']");
    private static readonly By ProjectWithoutMilestoneTextBy = By.XPath("//div[@class='empty-title']");
    private static readonly By ProjectNameLinkTextBy = By.XPath("//div[@class='summary-title text-ppp']/a");
    private static readonly By ProjectHasNotMilestoneTextBy = By.XPath("//h1[@class='top']/following::p");
    private static readonly By AddMilestoneLinkBy = By.Id("navigation-milestones-add");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddMilestoneLinkBy).Displayed;
    }

    public void EditProjectMilestoneClick()
    {
        EditProjectMilestoneLink.Click();
    }

    public void SelectMilestoneForDeleteClick()
    {
        MilestoneForDeleteCheckbox.SelectByIndexes([0]);
    }

    public bool DeleteProjectMilestoneLinkDisplayed()
    {
        return DeleteLink.Displayed;
    }

    public bool ConfirmationWindowDisplayed()
    {
        return ConfirmationWindow.Displayed;
    }

    public void SelectConfirmationForDeleteCheckbox()
    {
        ConfirmationForDeleteCheckbox.SelectByValues(["1"]);
    }

    public void DeleteButtonClick()
    {
        DeleteButton.Click();
    }

    public void DeleteLinkClick()
    {
        DeleteLink.Click();
    }

    public string GetSuccessMessageText()
    {
        return SuccessMessageText.Text.Trim().Replace("\"", "");
    }

    public string GetProjectWithoutMilestoneText()
    {
        return ProjectWithoutMilestoneText.Text.Trim().Replace("\"", "");
    }

    public string GetProjectNameLinkText()
    {
        return ProjectNameLinkText.Text.Trim();
    }

    public void AddMilestoneLinkClick()
    {
        AddMilestoneLink.Click();
    }

    public bool IsProjectHasNotMilestone()
    {
        return ProjectHasNotMilestoneText.Text.Replace("\r\n", " ")
            .Equals("This project doesn't have any active milestones. You can add a new milestone.");
    }

    protected UIElement ProjectHasNotMilestoneText => new(Driver, ProjectHasNotMilestoneTextBy);
    protected UIElement AddMilestoneLink => new(Driver, AddMilestoneLinkBy);
    protected UIElement EditProjectMilestoneLink => new(Driver, EditProjectMilestoneLinkBy);
    protected UIElement DeleteLink => new(Driver, DeleteLinkBy);
    protected UIElement ConfirmationWindow => new(Driver, ConfirmationWindowBy);
    protected Checkbox ConfirmationForDeleteCheckbox => new Checkbox(Driver, ConfirmationForDeleteCheckboxBy);
    protected Button DeleteButton => new Button(Driver, DeleteButtonBy);
    protected Checkbox MilestoneForDeleteCheckbox => new Checkbox(Driver, MilestoneForDeleteCheckboxBy);
    protected UIElement SuccessMessageText => new(Driver, SuccessMessageTextBy);
    protected UIElement ProjectWithoutMilestoneText => new(Driver, ProjectWithoutMilestoneTextBy);
    protected UIElement ProjectNameLinkText => new(Driver, ProjectNameLinkTextBy);
}