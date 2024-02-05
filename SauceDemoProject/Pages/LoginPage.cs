using OpenQA.Selenium;
using SauceDemoProject.Core;

namespace SauceDemoProject.Pages;

public class LoginPage : BasePage
{
    private static readonly By UsernameInputBy = By.Id("user-name");
    private static readonly By PasswordInputBy = By.Id("password");
    private static readonly By LoginButtonBy = By.Id("login-button");

    public LoginPage(IWebDriver driver) : base(driver)
    {
    }

    public IWebElement UsernameInput => Driver.FindElement(UsernameInputBy);

    public IWebElement PasswordInput => Driver.FindElement(PasswordInputBy);

    public IWebElement LoginButton => Driver.FindElement(LoginButtonBy);
}
