using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappProject.Tests;

public class ContextMenuTest : BaseTest
{
    [Test]
    public void AlertTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/context_menu");

        var actions = new Actions(Driver);

        var targetElements = WaitsHelper.WaitForAllVisibleElementsLocatedBy(By.Id("hot-spot"));

        actions
            .MoveToElement(targetElements[0], 50, 50)
            .ContextClick()
            .Build()
            .Perform();

        IAlert alert = Driver.SwitchTo().Alert();

        Assert.That(alert.Text, Is.EqualTo("You selected a context menu"));

        alert.Accept();
    }
}