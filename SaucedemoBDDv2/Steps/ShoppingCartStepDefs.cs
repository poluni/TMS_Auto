using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using SaucedemoCore.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SaucedemoCore.Pages.CheckoutPages;

namespace SaucedemoBDDv2.Steps;

[Binding]
public class ShoppingCartStepDefs : BaseSteps
{
    private ShoppingCartSteps _shoppingCartSteps;
    private readonly ProductsPage _productsPage;
    private readonly CheckoutThirdPage _checkoutThirdPage;

    public ShoppingCartStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _shoppingCartSteps = new ShoppingCartSteps(Driver);
        _productsPage = new ProductsPage(Driver);
        _checkoutThirdPage = new CheckoutThirdPage(Driver);
    }

    [Given(@"The user opened the product catalogue page")]
    public void IsProductsPageOpened()
    {
        _productsPage.IsPageOpened();
    }

    [Given(@"The shopping cart is empty")]
    public void IsShoppingCartEmpty()
    {
        if (!_shoppingCartSteps.IsEmptyCart())
            _shoppingCartSteps.RemoveItemFromCart();
    }

    [When(@"The user added one item to the shopping cart")]
    public void AddItemToShoppingCart()
    {
        _shoppingCartSteps.AddItemToCart();
    }

    [Then("Order is completed")]
    public void IsOrderCompleted()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_checkoutThirdPage.IsPageOpened);
            Assert.That(_shoppingCartSteps.IsOrderCompleted);
        });
    }
}

