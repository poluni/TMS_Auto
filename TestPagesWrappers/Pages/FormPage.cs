using OpenQA.Selenium;
using TestPagesWrappers.Elements;

namespace TestPagesWrappers.Pages;

public class FormPage : BasePage
{
    private static string END_POINT = "form-fields";
    
    // Описание элементов
    private static readonly By TitleHeaderBy = By.XPath("h1[itemprop='headline']");
    private static readonly By FormBy = By.Id("feedbackForm");
    private static readonly By ColorRadioButtonBy = By.Name("fav_color");
    private static readonly By DrinkCheckboxBy = By.Name("fav_drink");
    private static readonly By DropDownBy = By.XPath("//select[@name='siblings']/child::option");

    // Инициализация класса
    public FormPage(IWebDriver driver) : base(driver)
    {
    }

    public FormPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleHeader.Text.Trim().Equals("Form Fields");
    }

     //Атомарные Методы
    public UIElement TitleHeader => new (Driver, TitleHeaderBy);
    public RadioButton ColorRadioButton => new(Driver, ColorRadioButtonBy);
    public Checkbox DrinkCheckbox => new(Driver, DrinkCheckboxBy);
    public DropDown DropDown => new(Driver, DropDownBy);
}