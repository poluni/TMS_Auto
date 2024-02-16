using OpenQA.Selenium;
using SaucedemoPOMSteps.Pages;
using SaucedemoPOMSteps.Pages.CheckoutPages;

namespace SaucedemoPOMSteps.Steps;

public class NavigationSteps : BaseSteps
{
    private ShoppingCartPage _shoppingCartPage;
    private ProductsPage _productsPage;
    private CheckoutOnePage _checkoutOnePage;
    private CheckoutSecondPage _checkoutSecondePage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _shoppingCartPage = new ShoppingCartPage(driver);
        _productsPage = new ProductsPage(driver);
        _checkoutOnePage = new CheckoutOnePage(driver);
        _checkoutSecondePage = new CheckoutSecondPage(driver);
    }

    public ShoppingCartPage GoToShoppingCart()
    {
        _productsPage.HeaderPage.ShoppingCartLink.Click();
        return new ShoppingCartPage(Driver);
    }

    public CheckoutOnePage GoToCheckout()
    {
        _shoppingCartPage.CheckoutButton.Click();
        return new CheckoutOnePage(Driver);
    }

    public CheckoutSecondPage GoToSecondStepCheckout()
    {
        _checkoutOnePage.ContinueInput.Submit();
        return new CheckoutSecondPage(Driver);
    }

    public CheckoutThirdPage GoToThirdStepCheckout()
    {
        _checkoutSecondePage.FinishInput.Submit();
        return new CheckoutThirdPage(Driver);
    }
}