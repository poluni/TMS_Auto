using ChainOfInvocationsHW.Helpers.Configuration;
using OpenQA.Selenium;
using ChainOfInvocationsHW.Pages;
using ChainOfInvocationsHW.Pages.ProjectPages;

namespace ChainOfInvocationsHW.Steps;

public class NavigationSteps(IWebDriver driver) : BaseStep(driver)
{
    public DashboardPage SuccessfulLogin(string username, string password)
    {
        return Login<DashboardPage>(username, password);
    }

    public LoginPage IncorrectLogin(string username, string password)
    {
        return Login<LoginPage>(username, password);
    }

    private T Login<T>(string username, string password) where T : BasePage
    {
        LoginPage = new LoginPage(driver);
        LoginPage.EmailInput.SendKeys(username);
        LoginPage.PswInput.SendKeys(password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}