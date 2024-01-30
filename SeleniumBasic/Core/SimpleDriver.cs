using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public class SimpleDriver
{
    public IWebDriver Driver
    {
        get
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            // string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            
            //return new ChromeDriver(
            //    @"/Users/aleksandr.trostyanko/Documents/Work/TeachMeSkills/Code/CSharp/AQA_MTS/SeleniumBasic/Resources/");

            //return new ChromeDriver(path + @"/Resources/");
            
            return new ChromeDriver(basePath + @"/Resources/");
        }
    } 
}