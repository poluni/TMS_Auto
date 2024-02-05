using OpenQA.Selenium;
using SauceDemoProject.Helpers;
using SauceDemoProject.Helpers.Configuration;

namespace SauceDemoProject.Tests
{
    public class BasicLocatorsTest : BaseTest
    {
        [Test]
        [Description("Поиск локатора по ID")]
        public void ByIdTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.Id("react-burger-menu-btn")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по name")]
        public void ByNameTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=4");
            Assert.That(Driver.FindElement(By.Name("add-to-cart-sauce-labs-backpack")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по classname")]
        public void ByClassNameTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.ClassName("login_logo")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по tagname")]
        public void ByTagNameTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.TagName("footer")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по linktext")]
        public void ByLinkTextTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            var menu = Driver.FindElement(By.Id("react-burger-menu-btn"));
            menu.Click();
            Thread.Sleep(1000);
            Driver.FindElement(By.LinkText("Logout")).Click();
            Thread.Sleep(1000);
            Assert.Pass();
        }

        [Test]
        [Description("Поиск локатора по partiallinktext")]
        public void ByPartialLinkTextTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=4");
            var menu = Driver.FindElement(By.Id("react-burger-menu-btn"));
            menu.Click();
            Thread.Sleep(1000);
            var link = Driver.FindElement(By.PartialLinkText("All"));
            link.Click();
            Thread.Sleep(1000);
            Assert.Pass();
        }
    }
}
