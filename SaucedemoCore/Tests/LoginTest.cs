using SaucedemoCore.Helpers.Configuration;
using SaucedemoCore.Pages;
using SaucedemoCore.Steps;

namespace SaucedemoCore.Tests;

public class LoginTest : BaseTest
{
    private static readonly string LOCKED_USERNAME = "locked_out_user";
    private static readonly string VISUAL_ERROR_USERNAME = "visual_user";

    [Test]
    public void SuccessfullLoginTest()
    {
        UserSteps userSteps = new UserSteps(Driver);
        ProductsPage productsPage = userSteps
            .SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LockedUsernameLoginTest()
    {
        Assert.That(
            new UserSteps(Driver)
                .IncorrectLogin(LOCKED_USERNAME, Configurator.AppSettings.Password)
                .GetErrorButtonLoginText(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void VisualErrorUsernameLoginTest()
    {
        UserSteps userSteps = new UserSteps(Driver);
        ProductsPage productsPage = userSteps
            .SuccessfullLogin(VISUAL_ERROR_USERNAME, Configurator.AppSettings.Password);

        Assert.That(productsPage.HeaderPage.IsCartVisualFailureExisted);
    }
}