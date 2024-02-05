using OpenQA.Selenium;
using SauceDemoProject.Helpers;
using SauceDemoProject.Helpers.Configuration;

namespace SauceDemoProject.Tests
{
    public class CssLocatorsTest : BaseTest
    {
        [Test]
        [Description("Поиск локатора по css + .class")]
        public void ByCssClass1Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_list")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + .class1.class2")]
        public void ByCssClass2Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=4");
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_details_name.large_size")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + .class1 .class2 ")]
        public void ByCssClass3Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=4");
            Assert.That(Driver.FindElement(By.CssSelector(".inventory_details_img_container .inventory_details_img")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + #id")]
        public void ByCssIdTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=1");
            Assert.That(Driver.FindElement(By.CssSelector("#add-to-cart-sauce-labs-bolt-t-shirt")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + tagname")]
        public void ByCssTagnameTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.CssSelector("footer")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + tagname.class")]
        public void ByCssTagnameClassTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=4");
            Assert.That(Driver.FindElement(By.CssSelector("img.bm-icon")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute=value] ")]
        public void ByCssAttributeValue1Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=0");
            Assert.That(Driver.FindElement(By.CssSelector("[class=inventory_details_price]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute~=value] ")]
        public void ByCssAttributeValue2Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.CssSelector("[id~=root]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute|=value] ")]
        public void ByCssAttributeValue3Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "cart.html");
            Assert.That(Driver.FindElement(By.CssSelector("[data-test|=continue]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute^=value]")]
        public void ByCssAttributeValue4Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.CssSelector("[data-test^=product]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute$=value]")]
        public void ByCssAttributeValue5Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=0");
            Assert.That(Driver.FindElement(By.CssSelector("[class$=img]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по css + [attribute*=value]")]
        public void ByCssAttributeValue6Test()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "inventory-item.html?id=0");
            Assert.That(Driver.FindElement(By.CssSelector("[id*=ck-to-produc]")).Displayed);
        }
    }
}
