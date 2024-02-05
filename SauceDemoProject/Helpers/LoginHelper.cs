using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SauceDemoProject.Pages;
using OpenQA.Selenium;
using SauceDemoProject.Helpers.Configuration;

namespace SauceDemoProject.Helpers;

public class LoginHelper : LoginPage
{
    public LoginHelper(IWebDriver driver) : base(driver)
    {
    }

    public void Login()
    {
        var loginPage = new LoginPage(Driver);
        loginPage.UsernameInput.SendKeys(Configurator.AppSettings.Username);
        loginPage.PasswordInput.SendKeys(Configurator.AppSettings.Password);
        loginPage.LoginButton.Click();
    }
}

