using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaucedemoPOM.Pages.CheckoutPages
{
    public class CheckoutSecondPage : BasePage
    {
        private static string END_POINT = "checkout-step-two.html";

        public HeaderPage HeaderPage;

        // Описание элементов
        private static readonly By ItemInShoppingCartClassBy = By.CssSelector("[class=cart_item]");
        private static readonly By FinishInputBy = By.Id("finish");

        // Инициализация класса
        public CheckoutSecondPage(IWebDriver driver) : base(driver)
        {
            HeaderPage = new HeaderPage(Driver);
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return TitleClass.Text.Trim().Equals("Checkout: Overview");
        }

        public bool IsEmptyShoppingCart()
        {
            return ItemInShoppingCartClass.Text.Equals(string.Empty);
        }

        public CheckoutThirdPage GoToThirdStepCheckout()
        {
            FinishInput.Submit();
            return new CheckoutThirdPage(Driver);
        }

        // Атомарные Методы
        public IWebElement FinishInput => WaitsHelper.WaitForExists(FinishInputBy);
        public IWebElement ItemInShoppingCartClass => WaitsHelper.WaitForExists(ItemInShoppingCartClassBy);
    }
}
