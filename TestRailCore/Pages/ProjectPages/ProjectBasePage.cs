using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.ProjectPages;

public abstract class ProjectBasePage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private static readonly By NameInputBy = By.Id("name");
    private static readonly By AnnouncementTextAreaBy = By.Id("announcement_display");
    private static readonly By ShowAnnouncementCheckBoxBy = By.Id("show_announcement");
    private static readonly By TypeRadioButtonBy = By.Name("suite_mode");

    // Атомарные Методы
    internal UIElement NameInput => new(Driver, NameInputBy);
    internal UIElement AnnouncementTextArea => new(Driver, AnnouncementTextAreaBy);
    internal Checkbox ShowAnnouncementCheckBox => new Checkbox(Driver, ShowAnnouncementCheckBoxBy);
    internal RadioButton TypeRadioButton => new RadioButton(Driver, TypeRadioButtonBy);
}