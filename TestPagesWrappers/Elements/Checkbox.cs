using OpenQA.Selenium;
using TestPagesWrappers.Helpers;
using TestPagesWrappers.Helpers.Configuration;

namespace TestPagesWrappers.Elements;

public class Checkbox
{
    private List<UIElement> _uiElements;
    private List<string> _values;
    private List<string> _texts;

    /// <summary>
    /// Локатор данного элемента должен использовать атрибут name
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
            _texts.Add(uiElement.FindUIElement(By.XPath("following-sibling::label")).Text);
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
                throw new AssertionException("Превышен индекс");
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