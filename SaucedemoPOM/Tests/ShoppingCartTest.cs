using SaucedemoPOM.Helpers.Configuration;
using SaucedemoPOM.Pages;

namespace SaucedemoPOM.Tests;

public class ShoppingCartTest : BaseLoginTest
{
    [Test]
    public void AddItemToShoppingCartTest()
    {
        ProductsPage allProductPage = new ProductsPage(Driver);

        if (!allProductPage.HeaderPage.IsEmptyCart()) allProductPage.RemoveItemFromCart();

        int cntBefore = allProductPage.HeaderPage.GetCountItemInShoppingCart();

        allProductPage.AddItemToCart();

        int cntAfter = allProductPage.HeaderPage.GetCountItemInShoppingCart();

        Assert.Multiple(() =>
        {
            Assert.That(allProductPage.IsAddedToCart);
            Assert.That(cntAfter - cntBefore, Is.EqualTo(1));
        });
    }

    [Test]
    public void RemoveItemFromShoppingCartTest()
    {
        ProductsPage allProductPage = new ProductsPage(Driver);

        if (allProductPage.HeaderPage.IsEmptyCart()) allProductPage.AddItemToCart();

        int cntBefore = allProductPage.HeaderPage.GetCountItemInShoppingCart();

        allProductPage.RemoveItemFromCart();

        int cntAfter = allProductPage.HeaderPage.GetCountItemInShoppingCart();

        Assert.Multiple(() =>
        {
            Assert.That(allProductPage.IsRemovedFromCart);
            Assert.That(cntBefore - cntAfter, Is.EqualTo(1));
        });
    }
}