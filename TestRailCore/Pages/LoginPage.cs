using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages
{
    public class LoginPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "";

        // Описание элементов
        private static readonly By EmailInputBy = By.Id("name");
        private static readonly By PswInputBy = By.Id("password");
        private static readonly By RememberMeCheckboxBy = By.Id("rememberme");
        private static readonly By LoginInButtonBy = By.Id("button_primary");
        private static readonly By ErrorLabelBy = By.CssSelector("[data-testid='loginErrorText']");

        // Инициализация класса
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        protected override bool EvaluateLoadedStatus()
        {
            return LoginInButton.Displayed && EmailInput.Displayed;
        }

        public string GetErrorLabelText() => ErrorLabel.Text.Trim();

        public void SetEmail(string value)
        {
            EmailInput.SendKeys(value);
        }

        public void SetPassword(string value)
        {
            PswInput.SendKeys(value);
        }

        internal UIElement EmailInput => new(Driver, EmailInputBy);
        internal UIElement ErrorLabel => new(Driver, ErrorLabelBy);
        internal UIElement PswInput => new(Driver, PswInputBy);
        internal UIElement RememberMeCheckbox => new(Driver, RememberMeCheckboxBy);
        internal Button LoginInButton => new Button(Driver, LoginInButtonBy);
    }
}