using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages.MilestonePages;

public class EditMilestonePage(IWebDriver? driver, bool openByURL = false) : MilestoneBasePage(driver, openByURL)
{
    private const string END_POINT = "";

    // Описание элементов
    private static readonly By EditMilestoneBy = By.Id("accept");

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    protected override bool EvaluateLoadedStatus()
    {
        return WaitsHelper.WaitForVisibilityLocatedBy(EditMilestoneBy).Displayed;
    }

    // Атомарные Методы
    internal Button EditMilestone => new Button(Driver, EditMilestoneBy);
}
