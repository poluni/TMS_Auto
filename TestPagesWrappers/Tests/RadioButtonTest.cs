using OpenQA.Selenium;
using TestPagesWrappers.Elements;
using TestPagesWrappers.Helpers.Configuration;
using TestPagesWrappers.Pages;
using TestPagesWrappers.Steps;

namespace TestPagesWrappers.Tests;

public class RadioButtonTest : BaseTest
{
    [Test]
    public void RadioButtonSelectByTextTest()
    {
        new NavigationSteps(Driver).NavigateToForms().ColorRadioButton.SelectByText("Red");
    }

    [Test]
    public void RadioButtonSelectByValueTest()
    {
        new NavigationSteps(Driver).NavigateToForms().ColorRadioButton.SelectByValue("Red");
    }

    [Test]
    public void RadioButtonSelectByIndexTest()
    {
        new NavigationSteps(Driver).NavigateToForms().ColorRadioButton.SelectByIndex(0);
    }
}