using OpenQA.Selenium;
using ValueOfObjectsHW.Elements;
using ValueOfObjectsHW.Pages;

namespace ValueOfObjectsHW.Pages.ProjectPages;

public class AddProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By AddButtonBy = By.Id("accept");
    private static readonly By NameInputBy = By.Id("name");
    private static readonly By AnnouncementTextAreaBy = By.Id("announcement_display");
    private static readonly By ShowAnnouncementCheckBoxBy = By.Id("show_announcement");
    private static readonly By TypeRadioButtonBy = By.Name("suite_mode");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddButtonBy).Displayed;
    }

    // Атомарные Методы
    public Button AddButton => new Button(Driver, AddButtonBy);
    public UIElement NameInput => new(Driver, NameInputBy);
    public UIElement AnnouncementTextArea => new(Driver, AnnouncementTextAreaBy);
    public UIElement ShowAnnouncementCheckBox => new(Driver, ShowAnnouncementCheckBoxBy);
    public RadioButton TypeRadioButton => new RadioButton(Driver, TypeRadioButtonBy);
}