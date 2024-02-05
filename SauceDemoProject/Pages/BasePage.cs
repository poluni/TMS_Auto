using OpenQA.Selenium;
using SauceDemoProject.Core;

namespace SauceDemoProject.Pages;

    public class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; private set; }
    }

