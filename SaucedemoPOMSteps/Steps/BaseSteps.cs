using OpenQA.Selenium;

namespace SaucedemoPOMSteps.Steps;

public class BaseSteps
{
    protected IWebDriver Driver;

    public BaseSteps(IWebDriver driver)
    {
        Driver = driver;
    }
}