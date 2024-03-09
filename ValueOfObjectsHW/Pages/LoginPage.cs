using OpenQA.Selenium;
using ValueOfObjectsHW.Elements;

namespace ValueOfObjectsHW.Pages
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

        // Методы
        public UIElement EmailInput => new(Driver, EmailInputBy);
        public UIElement ErrorLabel => new(Driver, ErrorLabelBy);//WaitsHelper.WaitForExists(ErrorLabelBy);
        public UIElement PswInput => new(Driver, PswInputBy);
        public UIElement RememberMeCheckbox => new(Driver, RememberMeCheckboxBy);
        public Button LoginInButton => new Button(Driver, LoginInButtonBy);
    }
}