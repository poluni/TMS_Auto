using SaucedemoCore.Helpers.Configuration;
using SaucedemoCore.Steps;

namespace SaucedemoCore.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseLoginTest : BaseTest
{
    [SetUp]
    public void Login()
    {
        UserSteps userSteps = new UserSteps(Driver);
        userSteps.SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }
}