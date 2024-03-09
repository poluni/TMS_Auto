using ChainOfInvocationsHW.Helpers.Configuration;
using ChainOfInvocationsHW.Pages;

namespace ChainOfInvocationsHW.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        DashboardPage dashboardPage = _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void InvalidUsernameLoginTest()
    {
        Assert.That(_navigationSteps
            .IncorrectLogin("dgdsg", Configurator.AppSettings.Password)
            .GetErrorLabelText,
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}