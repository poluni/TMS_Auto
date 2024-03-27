using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages
{
    public class ProjectOverviewPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "";

        // Описание элементов
        private static readonly By OverviewLinkBy = By.XPath("//li[@class='header-menu-item header-menu-item-selected']/a[contains(@href,'overview')]");
        private static readonly By ReturnToDashboardLinkBy = By.Id("navigation-dashboard-top");
        private static readonly By FirstProjectAddedTextBy = By.ClassName("empty-title");
        private static readonly By MilestonesMenuBy = By.Id("navigation-milestones");

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return OverviewLink.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public bool IsPageOpened()
        {
            return OverviewLink.Displayed;
        }

        protected string GetFirstProjectSuccessfullAddedText()
        {
            return FirstProjectAddedText.Text;
        }

        public bool isFirstProjectAdded()
        {
            string expectedText = "Congratulations! You have created your first project";
            return GetFirstProjectSuccessfullAddedText().Equals(expectedText);
        }

        public void ReturnToDashboardClick()
        {
            ReturnToDashboardLink.Click();
        }

        public void MilestonesMenuClick()
        {
            MilestonesMenu.Click();
        }

        protected UIElement OverviewLink => new(Driver, OverviewLinkBy);
        protected UIElement ReturnToDashboardLink => new(Driver, ReturnToDashboardLinkBy);
        protected UIElement FirstProjectAddedText => new(Driver, FirstProjectAddedTextBy);
        protected UIElement MilestonesMenu => new(Driver, MilestonesMenuBy);
    }
}
