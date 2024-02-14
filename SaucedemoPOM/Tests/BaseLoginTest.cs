using SaucedemoPOM.Helpers.Configuration;
using SaucedemoPOM.Pages;

namespace SaucedemoPOM.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseLoginTest : BaseTest
{
    [SetUp]
    public void Login()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }
}