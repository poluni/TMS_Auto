using ValueOfObjectsHW.Helpers.Configuration;
using ValueOfObjectsHW.Pages;
using ValueOfObjectsHW.Models;

namespace ValueOfObjectsHW.Tests;

public class LoginTest : BaseTest
{
    private static readonly User userWithInvalidEmail = new User
    {
        Email = "fdbdfbfd@google.com",
        Password = Configurator.AppSettings.Password
    };

    [Test]
    public void SuccessfulLoginTest()
    {
        DashboardPage dashboardPage = _navigationSteps
            .SuccessfulLogin(Admin);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(_navigationSteps
            .IncorrectLogin(userWithInvalidEmail)
            .GetErrorLabelText,
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}