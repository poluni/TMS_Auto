using OpenQA.Selenium;
using SauceDemoProject.Helpers;
using SauceDemoProject.Helpers.Configuration;

namespace SauceDemoProject.Tests
{
    public class XPathLocatorsTest : BaseTest
    {
        [Test]
        [Description("Поиск локатора по xpath+атрибут")]
        public void ByXPathAttributeTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//div[@class='login_logo']")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath+текст атрибута")]
        public void ByXPathAttributeTextTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//h4[text()='Password for all users:']")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath+частичное совпадение атрибута")]
        public void ByXPathPartialAttributeTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//div[contains(@class,'login_password')]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath+частичное совпадение по тексту")]
        public void ByXPathAttributePartialTextTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//h4[contains(text(),'Accepted usernames ')]")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + Ancestor")]
        public void ByXPathAncestorTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.XPath("//li/ancestor::ul[@class = 'social']")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + Descendant")]
        public void ByXPathDescendantTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "checkout-step-one.html");
            Assert.That(Driver.FindElement(By.XPath("//div[@id='checkout_info_container']//descendant::div[@class='checkout_info']")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + Following")]
        public void ByXPathFollowingTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.XPath("//*[@class='inventory_list']//following::a[@id='item_1_img_link']")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + Parent")]
        public void ByXPathParentTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//input//parent::form")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + Preceding")]
        public void ByXPathPrecedingTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            Assert.That(Driver.FindElement(By.XPath("//h4//preceding::form")).Displayed);
        }

        [Test]
        [Description("Поиск локатора по xpath + AND")]
        public void ByXPathANDTest()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
            new LoginHelper(Driver).Login();
            Assert.That(Driver.FindElement(By.XPath("//select[@class='product_sort_container' and @data-test='product_sort_container']")).Displayed);
        }
    }
}
