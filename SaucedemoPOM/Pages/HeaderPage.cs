using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoPOM.Pages
{
    public class HeaderPage : BasePage
    {
        private static string END_POINT = "";
        private static readonly By HeaderClassBy = By.CssSelector("[class='primary_header']");
        private static readonly By CartVisualFailureClassBy = By.CssSelector("[class='shopping_cart_container visual_failure']");
        private static readonly By ShoppingCartClassBy = By.CssSelector("[class='shopping_cart_link']");
        private static readonly By ShoppingCartLinkBy = By.XPath("//a[@class='shopping_cart_link']");
        private static readonly By CountInShoppingCartClassBy = By.CssSelector("[class='shopping_cart_badge']");

        public HeaderPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return HeaderClass.Displayed;
        }

        public bool IsCartVisualFailureExisted()
        {
            return CartVisualFailureClass.Displayed;
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

        public IWebElement HeaderClass => WaitsHelper.WaitForExists(HeaderClassBy);
        public IWebElement CartVisualFailureClass => WaitsHelper.WaitForExists(CartVisualFailureClassBy);
        public IWebElement ShoppingCartClass => WaitsHelper.WaitForExists(ShoppingCartClassBy);
        public IWebElement ShoppingCartLink => WaitsHelper.WaitForExists(ShoppingCartLinkBy);
        public IWebElement CountInShoppingCartClass => WaitsHelper.WaitForExists(CountInShoppingCartClassBy);
    }
}
