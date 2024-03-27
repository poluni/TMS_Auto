using TestPagesWrappers.Steps;

namespace TestPagesWrappers.Tests;

public class DropDownTest : BaseTest
{
    [Test]
    public void DropDownSelectByTextTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByText("Yes");
    }

    [Test]
    public void DropDownSelectByValueTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByValue("no");
    }

    [Test]
    public void DropDownSelectByIndexTest()
    {
        new NavigationSteps(Driver).NavigateToForms().DropDown.SelectByIndex(2);
    }
}