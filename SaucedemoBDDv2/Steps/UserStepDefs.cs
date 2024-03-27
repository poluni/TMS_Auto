using SaucedemoCore.Core;
using SaucedemoCore.Pages;
using NUnit.Framework;
using SaucedemoCore.Steps;
using SaucedemoCore.Helpers.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaucedemoBDDv2.Steps;

[Binding]
public class LoginPageStepDefs : BaseSteps
{
    private UserSteps _userSteps;

    public LoginPageStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _userSteps = new UserSteps(Driver);
    }

    [Given(@"The user logged in with standart credentinals")]
    public void SuccessfullLogin()
    {
        _userSteps.SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }

    [When(@"Filled user data FIRSTNAME ""(.*)"", LASTNAME ""(.*)"" AND POSTAL_CODE ""(.*)""")]
    public void FillUserData(string firstname, string lastname, string postalCode)
    {
        _userSteps.FillUserData(firstname, lastname, postalCode);
    }
}