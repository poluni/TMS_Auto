using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using SaucedemoPOMSteps.Pages;
using SaucedemoPOMSteps.Pages.CheckoutPages;

namespace SaucedemoPOMSteps.Steps;

public class UserSteps : BaseSteps
{
    private LoginPage _loginPage;
    private CheckoutOnePage _userData;

    public UserSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
        _userData = new CheckoutOnePage(Driver);
    }

    [AllureStep("Авторизация пройдена:")]
    public ProductsPage SuccessfullLogin([Name("Login: ")] string username, [Name("Password: ")] string password)
    {
        _loginPage.UsernameInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return new ProductsPage(Driver);
    }

    [AllureStep("Авторизация не пройдена:")]
    public LoginPage IncorrectLogin([Name("Login: ")] string username, [Name("Password: ")] string password)
    {
        _loginPage.UsernameInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(password);
        _loginPage.LoginInButton.Click();

        return _loginPage;
    }

    [AllureStep("Заполнить данными пользователя:")]
    public void FillUserData(string firstname, string lastname, string postalCode)
    {
        _userData.FirstnameInput.SendKeys(firstname);
        _userData.LastnameInput.SendKeys(lastname);
        _userData.PostalCodeInput.SendKeys(postalCode);
    }

    public bool IsValidCustomerData()
    {
        return !_userData.ErrorButton.Displayed;
    }
}