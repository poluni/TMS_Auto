using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.MilestonePages;

public abstract class MilestoneBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private static readonly By NameMilestoneInputBy = By.Id("name");
    private static readonly By DescriptionTextAreaBy = By.Id("description_display");
    private static readonly By CompletedCheckBoxBy = By.Id("is_completed");

    // Атомарные Методы
    internal UIElement NameMileston => new(Driver, NameMilestoneInputBy);
    internal UIElement DescriptionTextArea => new(Driver, DescriptionTextAreaBy);
    internal Checkbox CompletedCheckBox => new Checkbox(Driver, CompletedCheckBoxBy);
}