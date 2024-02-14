using SaucedemoPOM.Helpers.Configuration;
using SaucedemoPOM.Pages;

namespace SaucedemoPOM.Tests;

public class ShoppingCartTest : BaseLoginTest
{
    [Test]
    public void AddItemToShoppingCartTest()
    {
        ProductsPage allProductPage = new ProductsPage(Driver);

        if (!allProductPage.IsEmptyCart()) allProductPage.RemoveItemFromCart();

        int cntBefore = allProductPage.GetCountItemInShoppingCart();

        allProductPage.AddItemToCart();

        int cntAfter = allProductPage.GetCountItemInShoppingCart();

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

        if (allProductPage.IsEmptyCart()) allProductPage.AddItemToCart();

        int cntBefore = allProductPage.GetCountItemInShoppingCart();

        allProductPage.RemoveItemFromCart();

        int cntAfter = allProductPage.GetCountItemInShoppingCart();

        Assert.Multiple(() =>
        {
            Assert.That(allProductPage.IsRemovedFromCart);
            Assert.That(cntBefore - cntAfter, Is.EqualTo(1));
        });
    }
}