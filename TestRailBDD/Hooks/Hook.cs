using TestRailCore.Helpers.Configuration;
using TestRailCore.Core;

namespace TestRailBDD.Hooks
{
    [Binding]
    public sealed class Hook
    {
        private readonly Browser _browser;

        public Hook(Browser browser)
        {
            _browser = browser;
        }

        [BeforeScenario("GUI", "Admin", Order = 0)]
        public void BeforeGUIScenario()
        {
            _browser.SetUpDriver();
            _browser.Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        [AfterScenario("GUI")]
        public void AfterScenario()
        {
            _browser.Driver.Quit();
        }
    }
}