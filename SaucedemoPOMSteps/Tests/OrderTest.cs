using SaucedemoPOMSteps.Helpers.Configuration;
using SaucedemoPOMSteps.Pages;
using SaucedemoPOMSteps.Pages.CheckoutPages;
using SaucedemoPOMSteps.Steps;

namespace SaucedemoPOMSteps.Tests;

public class OrderTest : BaseLoginTest
{
    private static readonly string FIRSTNAME = "Yan";
    private static readonly string LASTNAME = "Li";
    private static readonly string POSTAL_CODE = "454fdg-vfdv445";

    [Test]
    public void AddItemToOrderTest()
    {

        ShoppingCartSteps shoppingCartSteps = new ShoppingCartSteps(Driver);

        ProductsPage productsPage = new ProductsPage(Driver);

        if (!shoppingCartSteps.IsEmptyCart()) shoppingCartSteps.RemoveItemFromCart();

        int cntBefore = shoppingCartSteps.GetCountItemInShoppingCart();

        shoppingCartSteps.AddItemToCart();

        int cntAfter = shoppingCartSteps.GetCountItemInShoppingCart();

        Assert.Multiple(() =>
        {
            Assert.That(productsPage.IsAddedToCart);
            Assert.That(cntAfter - cntBefore, Is.EqualTo(1));
        });
    }

    [Test]
    public void RemoveItemFromOrderTest()
    {
        ShoppingCartSteps shoppingCartSteps = new ShoppingCartSteps(Driver);

        ProductsPage productsPage = new ProductsPage(Driver);

        if (shoppingCartSteps.IsEmptyCart()) shoppingCartSteps.AddItemToCart();

        int cntBefore = shoppingCartSteps.GetCountItemInShoppingCart();

        shoppingCartSteps.RemoveItemFromCart();

        int cntAfter = shoppingCartSteps.GetCountItemInShoppingCart();

        Assert.Multiple(() =>
        {
            Assert.That(productsPage.IsRemovedFromCart);
            Assert.That(cntBefore - cntAfter, Is.EqualTo(1));
        });
    }

    [Test]
    public void SuccessfullOrderTest()
    {
        ShoppingCartSteps shoppingCartSteps = new ShoppingCartSteps(Driver);
        NavigationSteps navigationSteps = new NavigationSteps(Driver);
        UserSteps userSteps = new UserSteps(Driver);

        CheckoutThirdPage checkoutThirdPage = new CheckoutThirdPage(Driver);

        if (!shoppingCartSteps.IsEmptyCart()) shoppingCartSteps.RemoveItemFromCart();

        shoppingCartSteps.AddItemToCart();

        navigationSteps.GoToShoppingCart();

        navigationSteps.GoToCheckout();

        userSteps.FillUserData(FIRSTNAME, LASTNAME, POSTAL_CODE);

        navigationSteps.GoToSecondStepCheckout();

        navigationSteps.GoToThirdStepCheckout();

        Assert.Multiple(() =>
        {
            Assert.That(checkoutThirdPage.IsPageOpened);
            Assert.That(shoppingCartSteps.IsOrderCompleted);
        });
    }
}