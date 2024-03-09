using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappProject.Tests;

public class DynamicControlsTest : BaseTest
{
    [Test]
    public void RemoveAddTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

        IWebElement removeBtn = WaitsHelper.WaitForExists(By.XPath("//button[contains(text(),'Remove')]"));

        IWebElement checkbox = WaitsHelper.WaitForExists(By.CssSelector("[type=checkbox]"));

        removeBtn.Click();

        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's gone!"));
            Assert.That(WaitsHelper.WaitForElementInvisible(checkbox));
        });
    }

    [Test]
    public void EnableDisableTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_controls");

        IWebElement input = WaitsHelper.WaitForExists(By.XPath("//form[@id='input-example']/descendant::input"));

        Assert.That(!input.Enabled);

        IWebElement enableBtn = WaitsHelper.WaitForExists(By.XPath("//button[contains(text(),'Enable')]"));

        enableBtn.Click();

        Assert.Multiple(() =>
        {
            Assert.That(WaitsHelper.WaitForVisibilityLocatedBy(By.Id("message")).Text, Is.EqualTo("It's enabled!"));
            Assert.That(input.Enabled);
        });
    }
}
