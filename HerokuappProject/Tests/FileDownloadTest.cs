using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumBasic.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HerokuappProject.Tests;

public class FileDownloadTest : BaseTest
{
    [Test]
    public void FileDownloaderTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");

        var link = WaitsHelper.WaitForExists(By.XPath("//div[@class='example']/a"));

        var fileNameText = link.Text;

        link.Click();

        Thread.Sleep(7_000);

        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        string pathDownload = Path.Combine(assemblyPath, "Resources");

        FileInfo[] files = new DirectoryInfo(pathDownload).GetFiles(searchPattern: $"{fileNameText}.*");

        var filePath = files[0].FullName;

        string fileName = Path.GetFileName(filePath);

        bool found = false;

        if (File.Exists(filePath))
        {
            Console.WriteLine($"Файл {fileName} скачан.");

            found = true;
        }

        Assert.That(found);

        File.Delete(filePath);
    }
}
