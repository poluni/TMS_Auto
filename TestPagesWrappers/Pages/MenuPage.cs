using OpenQA.Selenium;
using TestPagesWrappers.Elements;

namespace TestPagesWrappers.Pages;

public class MenuPage : BasePage
{
    private static string END_POINT = "";

    // Описание элементов
    private static readonly By FormFieldsLinkBy = By.XPath("//a[contains(@href,'form-fields')]");
    private static readonly By TablesLinkBy = By.XPath("//a[contains(@href,'tables')]");
    private static readonly By MenuTextBy = By.XPath("//h1/strong");

    // Инициализация класса
    public MenuPage(IWebDriver driver) : base(driver)
    {
    }

    public MenuPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return MenuText.Text.Trim().Equals("Welcome to your software automation practice website!");
    }

    //Атомарные Методы
    public UIElement FormFieldsLink => new(Driver, FormFieldsLinkBy);
    public UIElement TablesLink => new(Driver, TablesLinkBy);
    public UIElement MenuText => new(Driver, MenuTextBy);
}