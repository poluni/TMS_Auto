using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappProject.Tests;

public class FileUploadTest : BaseTest
{
    [Test]
    public void FileUploaderTest()
    {
        Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

        var fileUploadElement = WaitsHelper.WaitForExists(By.Id("file-upload"));

        string assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        string filePath = Path.Combine(assemblyPath, "Resources", "download.jpeg");

        fileUploadElement.SendKeys(filePath);

        WaitsHelper.WaitForExists(By.Id("file-submit")).Submit();

        var uploadedFile = WaitsHelper.WaitForExists(By.Id("uploaded-files"));

        Assert.That(uploadedFile.Text, Is.EqualTo("download.jpeg"));
    }
}
