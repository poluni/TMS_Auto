using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using SaucedemoCore.Pages;

namespace SaucedemoBDDv2.Steps;

[Binding]
public sealed class NavigationStepDefs : BaseSteps
{
    private NavigationSteps _navigationSteps;

    public NavigationStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
    }

    [When(@"Navigated to the shopping cart")]
    public void GoToShoppingCart()
    {
        _navigationSteps.GoToShoppingCart();
    }

    [When(@"Navigated to checkout")]
    public void GoToCheckout()
    {
        _navigationSteps.GoToCheckout();
    }

    [When(@"Navigated to second step checkout")]
    public void GoToSecondStepCheckout()
    {
        _navigationSteps.GoToSecondStepCheckout();
    }

    [When(@"Navigated to third step checkout")]
    public void GoToThirdStepCheckout()
    {
        _navigationSteps.GoToThirdStepCheckout();
    }
}