using SaucedemoPOM.Helpers.Configuration;
using SaucedemoPOM.Pages;

namespace SaucedemoPOM.Tests;

public class LoginTest : BaseTest
{
    private static readonly string LOCKED_USERNAME = "locked_out_user";
    private static readonly string VISUAL_ERROR_USERNAME = "visual_user";

    [Test]
    public void SuccessfulLoginTest()
    {
        // Простой вид
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        ProductsPage allProductPage = new ProductsPage(Driver);

        // Проверка 
        Assert.That(allProductPage.IsPageOpened);
    }

    [Test]
    public void LockedUsernameLoginTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin(LOCKED_USERNAME, Configurator.AppSettings.Password)
                .ErrorButton.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void VisualErrorUsernameLoginTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessfullLogin(VISUAL_ERROR_USERNAME, Configurator.AppSettings.Password);
        ProductsPage allProductPage = new ProductsPage(Driver);

        Assert.That(allProductPage.IsCartVisualFailureExisted);
    }
}