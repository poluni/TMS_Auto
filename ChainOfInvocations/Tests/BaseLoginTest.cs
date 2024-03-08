using ChainOfInvocationsHW.Helpers.Configuration;
using ChainOfInvocationsHW.Pages;

namespace ChainOfInvocationsHW.Tests;

public class BaseLoginTest : BaseTest
{
    [SetUp]
    public void SuccessfulLoginTest()
    {
        _navigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }
}

