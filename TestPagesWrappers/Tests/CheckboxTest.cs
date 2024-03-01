using OpenQA.Selenium;
using TestPagesWrappers.Elements;
using TestPagesWrappers.Helpers.Configuration;
using TestPagesWrappers.Pages;
using TestPagesWrappers.Steps;

namespace TestPagesWrappers.Tests;

public class CheckboxTest : BaseTest
{
    [Test]
    public void CheckboxTestSelectByTextTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DrinkCheckbox.SelectByTexts(["Water", "Coffee"]);
    }

    [Test]
    public void CheckboxTestSelectByValueTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DrinkCheckbox.SelectByValues(["Water","Coffee"]);
    }

    [Test]
    public void CheckboxTestSelectByIndexTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DrinkCheckbox.SelectByIndexes([0, 2]);
    }
}