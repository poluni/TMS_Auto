using OpenQA.Selenium;
using SaucedemoPOM.Helpers;
using SaucedemoPOM.Helpers.Configuration;

namespace SaucedemoPOM.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "inventory.html";

    public HeaderPage HeaderPage;

    // Описание элементов
    private static readonly By BackpackAddButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By BackpackRemoveButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By BackpackItemClassBy = By.XPath("//a[@Id='item_4_title_link']/div");

    // Инициализация класса
    public ProductsPage(IWebDriver driver) : base(driver)
    {
        HeaderPage = new HeaderPage(Driver);
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleClass.Text.Trim().Equals("Products");
    }

    public bool AddItemToCart()
    {
        BackpackAddButton.Click();
        return IsAddedToCart();
    }

    public bool RemoveItemFromCart()
    {
        BackpackRemoveButton.Click();
        return IsRemovedFromCart();
    }

    public bool IsAddedToCart()
    {
        return BackpackRemoveButton.Displayed;
    }

    public bool IsRemovedFromCart()
    {
        return BackpackAddButton.Displayed;
    }

    // Атомарные Методы
    public IWebElement BackpackAddButton => WaitsHelper.WaitForExists(BackpackAddButtonBy);
    public IWebElement BackpackRemoveButton => WaitsHelper.WaitForExists(BackpackRemoveButtonBy);
    public IWebElement BackpackItemClass => WaitsHelper.WaitForExists(BackpackItemClassBy);
}