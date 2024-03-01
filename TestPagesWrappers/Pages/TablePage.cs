using OpenQA.Selenium;
using TestPagesWrappers.Elements;

namespace TestPagesWrappers.Pages;

public class TablePage : BasePage
{
    private static string END_POINT = "TablePage";
    
    // Описание элементов
    private static readonly By TitleHeaderBy = By.XPath("h1[itemprop='headline']");
    private static readonly By TableBy = By.Id("tablepress-1");

    // Инициализация класса
    public TablePage(IWebDriver driver) : base(driver)
    {
    }

    public TablePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleHeader.Text.Trim().Equals("Tables");
    }

     //Атомарные Методы
    public UIElement TitleHeader => new (Driver, TitleHeaderBy);
    public Table Table => new(Driver, TableBy);
}