using SaucedemoPOM.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoPOM.Tests
{
    public class OrderTest : BaseLoginTest
    {
        [Test]
        public void MakeOrderTest()
        {
            ProductsPage allProductPage = new ProductsPage(Driver);
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(Driver);
            CheckoutOnePage checkoutOnePage = new CheckoutOnePage(Driver);
            CheckoutSecondePage checkoutSecondPage = new CheckoutSecondePage(Driver);
            CheckoutThirdPage checkoutThirdPage = new CheckoutThirdPage(Driver);

            if (!allProductPage.IsEmptyCart()) allProductPage.RemoveItemFromCart();

            allProductPage.AddItemToCart();

            allProductPage.GoToShoppingCart();

            shoppingCartPage.GoToCheckout();

            checkoutOnePage.FillCustomerData();

            checkoutOnePage.GoToSecondStepCheckout();

            checkoutSecondPage.GoToThirdStepCheckout();

            Assert.Multiple(() =>
            {
                Assert.That(checkoutThirdPage.IsPageOpened);
                Assert.That(checkoutThirdPage.IsOrderCompleted);
            });
        }
    }
}
