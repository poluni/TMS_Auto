using ChainOfInvocationsHW.Elements;
using OpenQA.Selenium;

namespace ChainOfInvocationsHW.Pages.ProjectPages;

public class UpdateProjectPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
{
    private const string END_POINT = "index.php?/admin/projects/add";

    // Описание элементов
    private static readonly By SaveButtonBy = By.Id("name");

    protected override bool EvaluateLoadedStatus()
    {
        return SaveButton.Displayed;
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    // Атомарные Методы
    public Button SaveButton => new Button(Driver, SaveButtonBy);
}