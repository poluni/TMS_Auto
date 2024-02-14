using OpenQA.Selenium;
using SaucedemoPOM.Helpers;
using SaucedemoPOM.Helpers.Configuration;

namespace SaucedemoPOM.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "inventory.html";

    // Описание элементов
    private static readonly By CartVisualFailureClassBy = By.CssSelector("[class='shopping_cart_container visual_failure']");
    private static readonly By ShoppingCartClassBy = By.CssSelector("[class='shopping_cart_link']");
    private static readonly By ShoppingCartLinkBy = By.XPath("//a[@class='shopping_cart_link']");
    private static readonly By CountInShoppingCartClassBy = By.CssSelector("[class='shopping_cart_badge']");
    private static readonly By BackpackAddButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By BackpackRemoveButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By BackpackItemClassBy = By.XPath("//a[@Id='item_4_title_link']/div");

    // Инициализация класса
    public ProductsPage(IWebDriver driver) : base(driver) { }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        return TitleClass.Text.Trim().Equals("Products");
    }

    public bool IsCartVisualFailureExisted()
    {
        return CartVisualFailureClass.Displayed;
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

    public bool IsEmptyCart()
    {
        return ShoppingCartLink.Text.Equals(string.Empty);
    }

    public int GetCountItemInShoppingCart()
    {
        int count = 0;
        if (!IsEmptyCart())
        {
            int.TryParse(CountInShoppingCartClass?.Text.Trim(), out count);
            return count;
        }
        return count;
    }

    public ShoppingCartPage GoToShoppingCart()
    {
        ShoppingCartLink.Click();
        return new ShoppingCartPage(Driver);
    }

    // Атомарные Методы
    public IWebElement CartVisualFailureClass => WaitsHelper.WaitForExists(CartVisualFailureClassBy);
    public IWebElement BackpackAddButton => WaitsHelper.WaitForExists(BackpackAddButtonBy);
    public IWebElement BackpackRemoveButton => WaitsHelper.WaitForExists(BackpackRemoveButtonBy);
    public IWebElement ShoppingCartClass => WaitsHelper.WaitForExists(ShoppingCartClassBy);
    public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);
    public IWebElement CountInShoppingCartClass => WaitsHelper.WaitForExists(CountInShoppingCartClassBy);
    public IWebElement BackpackItemClass => WaitsHelper.WaitForExists(BackpackItemClassBy);
}