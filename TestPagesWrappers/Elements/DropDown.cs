using OpenQA.Selenium;
using TestPagesWrappers.Helpers;
using TestPagesWrappers.Helpers.Configuration;

namespace TestPagesWrappers.Elements;

public class DropDown
{
    private List<UIElement> _uiElements;
    private List<string> _values;
    private List<string> _texts;

    /// <param name="webDriver"></param>
    /// <param name="by"></param>
    public DropDown(IWebDriver webDriver, By by)
    {
        _uiElements = new List<UIElement>();
        _values = new List<string>();
        _texts = new List<string>();

        WaitsHelper _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        foreach (var webElement in _waitsHelper.WaitForPresenceOfAllElementsLocatedBy(by))
        {
            UIElement uiElement = new UIElement(webDriver, webElement);
            _uiElements.Add(uiElement);
            _values.Add(uiElement.GetAttribute("value"));
            _texts.Add(uiElement.Text);
        }
    }

    public void SelectByIndex(int index)
    {
        if (index < _uiElements.Count)
        {
            _uiElements[index].Click();
        }
        else
        {
            throw new AssertionException("Index is out of range");
        }
    }

    public void SelectByValue(string value)
    {
        _uiElements[_values.IndexOf(value)].Click();
    }

    public void SelectByText(string text)
    {
        var index = _texts.IndexOf(text);
        _uiElements[index].Click();
    }

    public List<string> GetOptions()
    {
        return _texts;
    }
}