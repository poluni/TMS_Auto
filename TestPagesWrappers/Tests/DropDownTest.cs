using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestPagesWrappers.Elements;
using TestPagesWrappers.Helpers.Configuration;
using TestPagesWrappers.Pages;
using TestPagesWrappers.Steps;

namespace TestPagesWrappers.Tests;

public class DropDownTest : BaseTest
{
    /*
    [Test]
    public void DropDownSelectTest1()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "form-fields");
        var drDowm = Driver.FindElement(By.Name("siblings"));
        var selectElement = new SelectElement(drDowm);
        selectElement.SelectByText("Yes");
        Thread.Sleep(2_000);
    }

    [Test]
    public void DropDownSelectTest2()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "form-fields");
        var drDowm = Driver.FindElement(By.Name("siblings"));
        var selectElement = new SelectElement(drDowm);
        selectElement.SelectByValue("yes");
        Thread.Sleep(2_000);
    }
    */
    /*
    [Test]
    public void DropDownSelectTest3()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + "form-fields");
        var drDowm = Driver.FindElement(By.Name("siblings"));
        var selectElement = new SelectElement(drDowm);
        selectElement.SelectByIndex(1);
        Thread.Sleep(2_000);
    }
    */
    
    [Test]
    public void DropDownSelectByTextTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByText("Yes");
        Thread.Sleep(2_000);
    }
    /*
    [Test]
    public void DropDownSelectByValueTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByValue("yes");
        Thread.Sleep(2_000);
    }

    [Test]
    public void DropDownSelectByIndexTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByIndex(1);
        Thread.Sleep(2_000);
    }

    [Test]
    public void DropDownSelectByOptionTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByOption("Yes");
        Thread.Sleep(2_000);
    }
    */

}