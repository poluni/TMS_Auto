using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.MilestonePages;

public class AddMilestonePage(IWebDriver? driver, bool openByURL = false) : MilestoneBasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By AddMilestoneButtonBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(AddMilestoneButtonBy).Displayed;
    }

    // Атомарные Методы
    internal Button AddMilestoneButton => new Button(Driver, AddMilestoneButtonBy);
}