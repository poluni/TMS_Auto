using Allure.Net.Commons;
using NUnit.Allure.Attributes;
using SaucedemoPOMSteps.Helpers.Configuration;
using SaucedemoPOMSteps.Pages;
using SaucedemoPOMSteps.Steps;

namespace SaucedemoPOMSteps.Tests;

public class LoginTest : BaseTest
{
    private static readonly string LOCKED_USERNAME = "locked_out_user";
    private static readonly string VISUAL_ERROR_USERNAME = "visual_user";

    [Test]
    public void SuccessfullLoginTest()
    {
        AllureApi.SetTestName("����������� ��� ���������� �������.");
        AllureApi.SetDescription("����������� ��� ���������� �������. ����������� �������.");
        AllureApi.SetSeverity(SeverityLevel.critical);
        AllureApi.AddTags("UI");
        AllureApi.AddParentSuite("�����������");

        UserSteps userSteps = new UserSteps(Driver);
        ProductsPage productsPage = userSteps
            .SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(productsPage.IsPageOpened);
    }

    [Test]
    public void LockedUsernameLoginTest()
    {
        AllureApi.SetTestName("����������� ��� ��������������� �������.");
        AllureApi.SetDescription("����������� ��� �������, ������� ������������. ����������� �� �������.");
        AllureApi.SetSeverity(SeverityLevel.critical);
        AllureApi.AddTags("UI");
        AllureApi.AddParentSuite("�����������");

        Assert.That(
            new UserSteps(Driver)
                .IncorrectLogin(LOCKED_USERNAME, Configurator.AppSettings.Password)
                .GetErrorButtonLoginText(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void VisualErrorUsernameLoginTest()
    {
        AllureApi.SetTestName("����������� ��� ������� c �������� ����������.");
        AllureApi.SetDescription("����������� ��� �������, ��� �������� ������������ ������ ����������. ����������� �������.");
        AllureApi.SetSeverity(SeverityLevel.trivial);
        AllureApi.AddTags("UI");
        AllureApi.AddParentSuite("�����������");

        UserSteps userSteps = new UserSteps(Driver);
        ProductsPage productsPage = userSteps
            .SuccessfullLogin(VISUAL_ERROR_USERNAME, Configurator.AppSettings.Password);

        Assert.That(productsPage.HeaderPage.IsCartVisualFailureExisted);
    }
}