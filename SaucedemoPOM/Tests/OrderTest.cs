using SaucedemoPOM.Pages;
using SaucedemoPOM.Pages.CheckoutPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoPOM.Tests
{
    public class OrderTest : BaseLoginTest
    {
        private static readonly string FIRSTNAME = "Yan";
        private static readonly string LASTNAME = "Li";
        private static readonly string POSTAL_CODE = "454fdg-vfdv445";

        [Test]
        public void MakeOrderTest()
        {
            ProductsPage allProductPage = new ProductsPage(Driver);
            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(Driver);
            CheckoutOnePage checkoutOnePage = new CheckoutOnePage(Driver);
            CheckoutSecondPage checkoutSecondPage = new CheckoutSecondPage(Driver);
            CheckoutThirdPage checkoutThirdPage = new CheckoutThirdPage(Driver);

            if (!allProductPage.HeaderPage.IsEmptyCart()) allProductPage.RemoveItemFromCart();

            allProductPage.AddItemToCart();

            allProductPage.HeaderPage.GoToShoppingCart();

            shoppingCartPage.GoToCheckout();

            checkoutOnePage.FillCustomerData(FIRSTNAME, LASTNAME, POSTAL_CODE);

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
