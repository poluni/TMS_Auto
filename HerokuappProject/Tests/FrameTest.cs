using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace HerokuappProject.Tests;

public class FrameTest : BaseTest
{
    [Test]
    public void FrameTextTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/frames");

        Driver.FindElement(By.XPath("//a[contains(text(),'iFrame')]")).Click();

        Driver.SwitchTo().Frame(Driver.FindElement(By.Id("mce_0_ifr")));

        var textArea = WaitsHelper.WaitForVisibilityLocatedBy(By.XPath("//body[@id='tinymce']/descendant::p")).Text;

        Assert.That(textArea, Is.EqualTo("Your content goes here."));
    }
}
