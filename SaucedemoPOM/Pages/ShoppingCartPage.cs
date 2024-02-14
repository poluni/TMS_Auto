using OpenQA.Selenium;
using SaucedemoPOM.Pages.CheckoutPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoPOM.Pages
{
    public class ShoppingCartPage : BasePage
    {
        private static string END_POINT = "cart.html";

        // Описание элементов
        private static readonly By CheckoutButtonBy = By.Id("checkout");
        private static readonly By ItemInShoppingCartClassBy = By.CssSelector("[class=cart_item]");

        // Инициализация класса
        public ShoppingCartPage(IWebDriver driver) : base(driver) { }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleClass.Text.Trim().Equals("Your Cart");
        }

        public bool IsEmptyShoppingCart()
        {
            return ItemInShoppingCartClass.Text.Equals(string.Empty);
        }

        public CheckoutOnePage GoToCheckout()
        {
            CheckoutButton.Click();
            return new CheckoutOnePage(Driver);
        }

        // Атомарные Методы
        public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
        public IWebElement ItemInShoppingCartClass => WaitsHelper.WaitForExists(ItemInShoppingCartClassBy);
    }
}
