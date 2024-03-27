using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.TestCasePages;

public class ProjectTestCasesPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By AddTestCaseLinkBy = By.Id("sidebar-cases-add");
    private static readonly By TestCaseForEditingCheckboxBy = By.ClassName("selectionCheckbox");
    private static readonly By EditLinkBy = By.XPath("//a[@class='editLink']");
    private static readonly By DeleteLinkBy = By.XPath("//a[@class='deleteLink']");
    private static readonly By ConfirmationForDeleteLinkBy = By.XPath("//div[@id='casesDeletionDialog']//a[contains(text(),'Delete Permanently')]");
    private static readonly By DeletePermanentlyLinkBy = By.XPath("//div[@id='casesDeletionConfirmationDialog']//a[contains(text(),'Delete Permanently')]");
    private static readonly By CountTestCasesBy = By.Id("sectionCount-1");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddTestCaseLinkBy).Displayed;
    }

    public void SelectTestCaseForEditClick()
    {
        TestCaseForEditingCheckbox.SelectByIndexes([1]);
    }

    public void EditLinkClick()
    {
        EditLink.Click();
    }

    public void DeleteTestCaseLinkClick()
    {
        DeleteLink.Click();
    }

    public void DeleteTestCasePermanently()
    {
        ConfirmationForDeleteLink.Click();
    }

    public void DeleteTestCase()
    {
        DeletePermanentlyLink.Click();
    }

    public string CountTestCaseText()
    {
        return CountTestCases.Text.Trim();
    }

    internal UIElement AddTestCaseLink => new(Driver, AddTestCaseLinkBy);
    protected Checkbox TestCaseForEditingCheckbox => new Checkbox(Driver, TestCaseForEditingCheckboxBy);
    protected UIElement EditLink => new(Driver, EditLinkBy);
    protected UIElement DeleteLink => new(Driver, DeleteLinkBy);
    protected UIElement ConfirmationForDeleteLink => new(Driver, ConfirmationForDeleteLinkBy);
    protected UIElement DeletePermanentlyLink => new(Driver, DeletePermanentlyLinkBy);
    protected UIElement CountTestCases => new(Driver, CountTestCasesBy);
}