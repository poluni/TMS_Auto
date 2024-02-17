using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SaucedemoPOMSteps.Pages;
using SaucedemoPOMSteps.Pages.CheckoutPages;
using SaucedemoPOMSteps.Helpers.Configuration;

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

    [AllureStep("Перейти в корзину.")]
    public ShoppingCartPage GoToShoppingCart()
    {
        _productsPage.HeaderPage.ShoppingCartLink.Click();
        return new ShoppingCartPage(Driver);
    }

    [AllureStep("Перейти к заполнению данных пользователя.")]
    public CheckoutOnePage GoToCheckout()
    {
        _shoppingCartPage.CheckoutButton.Click();
        return new CheckoutOnePage(Driver);
    }

    [AllureStep("Перейти к подтверждению заказа.")]
    public CheckoutSecondPage GoToSecondStepCheckout()
    {
        _checkoutOnePage.ContinueInput.Submit();
        return new CheckoutSecondPage(Driver);
    }

    [AllureStep("Подтвердить заказ.")]
    public CheckoutThirdPage GoToThirdStepCheckout()
    {
        _checkoutSecondePage.FinishInput.Submit();
        return new CheckoutThirdPage(Driver);
    }
}