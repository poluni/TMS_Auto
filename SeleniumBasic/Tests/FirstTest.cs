using AngleSharp.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;
using System.Text;
using System.Text.RegularExpressions;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");

        IWebElement weightInput = Driver.FindElement(By.Name("weight"));
        IWebElement heightInput = Driver.FindElement(By.Name("height"));
        IWebElement calcButton = Driver.FindElement(By.Id("calc-mass-c"));

        weightInput.SendKeys("80");
        heightInput.SendKeys("183");
        calcButton.Click();

        IWebElement resultText = Driver.FindElement(By.Id("imt-result"));
        Assert.That(resultText.Text, Is.EqualTo("23.9 - Норма"));
    }

    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");

        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(0);

        IWebElement ageInput = Driver.FindElement(By.Id("age"));
        IWebElement selectSexDropdown = Driver.FindElement(By.Id("sex"));
        SelectElement selectSexElement = new SelectElement(selectSexDropdown);
        IWebElement crInput = Driver.FindElement(By.Id("cr"));
        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectElement = new SelectElement(selectDropdown);
        IWebElement selectRaceDropdown = Driver.FindElement(By.Id("race"));
        SelectElement selectRaceElement = new SelectElement(selectRaceDropdown);
        IWebElement massInput = Driver.FindElement(By.Id("mass"));
        IWebElement growInput = Driver.FindElement(By.Id("grow"));
        IWebElement calcButton = Driver.FindElement(By.TagName("button"));

        ageInput.SendKeys("20");

        selectSexElement.SelectByValue("M");
        Thread.Sleep(3000);

        crInput.SendKeys("115");

        selectElement.SelectByValue("mg");
        Thread.Sleep(3000);

        selectRaceElement.SelectByValue("N");
        Thread.Sleep(3000);

        massInput.SendKeys("115");
        growInput.SendKeys("195");

        calcButton.Click();
        Thread.Sleep(3000);

        IWebElement mdrdText = Driver.FindElement(By.Id("mdrd_res"));
        IWebElement ckdText = Driver.FindElement(By.Id("ckd_epi_res"));
        IWebElement cgeText = Driver.FindElement(By.Id("cge_res"));
        IWebElement schwartzText = Driver.FindElement(By.Id("schwartz_res"));

        Assert.That(mdrdText.Text, Is.EqualTo("0.48"));
        Assert.That(ckdText.Text, Is.EqualTo("0.4"));
        Assert.That(cgeText.Text, Is.EqualTo("1.67"));
        Assert.That(schwartzText.Text, Is.EqualTo("1.19"));
    }

    [Test]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
        Thread.Sleep(5000);

        IWebElement areaInput = Driver.FindElement(By.Id("area"));
        IWebElement calcButton = Driver.FindElement(By.Id("btn_calculate"));

        areaInput.SendKeys("30");
        calcButton.Click();
        Thread.Sleep(3000);

        string parsedText = Driver.FindElement(By.ClassName("calc-result")).Text;
        var pattern = "[^а-яА-Я0-9]+";
        var normalizedText = Regex.Replace(parsedText, pattern, "");

        string expectedResult = @"Требуемоеколичествоплашекламината45Количествоупаковокламината5Стоимостьламината0рубВесламината0кг";

        Assert.That(normalizedText, Is.EqualTo(expectedResult));
    }
}