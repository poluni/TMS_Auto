using TestRailCore.Elements;
using OpenQA.Selenium;

namespace TestRailCore.Pages
{
    public class DashboardPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "index.php?/dashboard";

        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");
        private static readonly By TitleLabelBy = By.ClassName("page_title");
        private static readonly By AddFirstProjectTextBy = By.ClassName("empty-title");
        private static readonly By ProjectMilestonesLinkBy = By.XPath("//a[contains(text(),'Milestones') and @class='link']");
        private static readonly By ProjectTestCasesLinkBy = By.XPath("//a[contains(text(),'Test Cases') and @class='link']");

        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed;
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
            return TitleLabel.Displayed;
        }

        public string GetAddFirstProjectText()
        {
            return AddFirstProjectText.Text;
        }

        public bool IsFirstProject()
        {
            return GetAddFirstProjectText().Equals("Add your first project to TestRail");
        }

        public void AddProjectClick()
        {
            SidebarProjectsAddButton.Click();
        }

        public void GoToProjectMilestonesClick()
        {
            ProjectMilestonesLink.Click();
        }

        public void GoToProjectTestCasesClick()
        {
            ProjectTestCasesLink.Click();
        }

        protected Button SidebarProjectsAddButton => new Button(Driver, SidebarProjectsAddButtonBy);
        protected UIElement TitleLabel => new(Driver, TitleLabelBy);
        protected UIElement AddFirstProjectText => new(Driver, AddFirstProjectTextBy);
        protected UIElement ProjectMilestonesLink => new(Driver, ProjectMilestonesLinkBy);
        protected UIElement ProjectTestCasesLink => new(Driver, ProjectTestCasesLinkBy);
    }
}