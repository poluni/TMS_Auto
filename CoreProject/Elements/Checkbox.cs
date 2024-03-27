using OpenQA.Selenium;
using CoreProject.Helpers;
using CoreProject.Helpers.Configuration;

namespace CoreProject.Elements;

public class Checkbox
{
    private List<UIElement> _uiElements;
    private List<string> _values;
    private List<string> _texts;

    /// <summary>
    /// By name
    /// </summary>
    /// <param name="webDriver"></param>
    /// <param name="by"></param>

    public Checkbox(IWebDriver webDriver, By by)
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
            _texts.Add(uiElement.FindUIElement(By.XPath("parent::*/input")).Text.Trim());
        }
    }

    public void SelectByIndexes(int[] indexes)
    {
        foreach (var i in indexes)
        {
            if (i < _uiElements.Count)
            {
                _uiElements[i].Click();
            }
            else
            {
                throw new AssertionException("Index is out of range");
            }
        }
    }

    public void SelectByValues(string[] values)
    {
        foreach (var i in values) _uiElements[_values.IndexOf(i)].Click();
    }

    public void SelectByTexts(string[] texts)
    {
        foreach (var txt in texts)
        {
            var index = _texts.IndexOf(txt);
            _uiElements[index].Click();
        }
    }
}
