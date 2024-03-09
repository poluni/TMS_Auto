using OpenQA.Selenium;
using ValueOfObjectsHW.Pages;
using ValueOfObjectsHW.Models;

namespace ValueOfObjectsHW.Steps;

public class NavigationSteps(IWebDriver driver) : BaseStep(driver)
{
    public DashboardPage SuccessfulLogin(User user)
    {
        return Login<DashboardPage>(user);
    }

    public LoginPage IncorrectLogin(User user)
    {
        return Login<LoginPage>(user);
    }

    private T Login<T>(User user) where T : BasePage
    {
        LoginPage = new LoginPage(driver);
        LoginPage.EmailInput.SendKeys(user.Email);
        LoginPage.PswInput.SendKeys(user.Password);
        LoginPage.LoginInButton.Click();

        return (T)Activator.CreateInstance(typeof(T), Driver, false);
    }
}