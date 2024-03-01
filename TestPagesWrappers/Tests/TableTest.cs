using OpenQA.Selenium;
using TestPagesWrappers.Elements;
using TestPagesWrappers.Helpers.Configuration;
using TestPagesWrappers.Pages;
using TestPagesWrappers.Steps;

namespace TestPagesWrappers.Tests;

public class TableTest : BaseTest
{
    [Test]
    public void TableCellTest()
    {
        TablePage _tablePage = new NavigationSteps(Driver).NavigateToTables();
        TableRow tableRow = _tablePage.Table.GetRow("Country", "India");
        TableCell tableCell = tableRow.GetCell(1);
        Assert.That(tableCell.Text, Is.EqualTo("India"));
    }
}