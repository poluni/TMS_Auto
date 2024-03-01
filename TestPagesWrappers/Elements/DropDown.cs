using AngleSharp.Dom;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using TestPagesWrappers.Helpers;
using TestPagesWrappers.Helpers.Configuration;

namespace TestPagesWrappers.Elements;

public class DropDown
{
    private UIElement _uiElement;
    private List<string> _options;
    //private List<UIElement> _uiElements;
    //private List<string> _values;
    //private List<string> _texts;
    //private List<UIElement> _options;
    private List<string>  _txtOptions;

    /// <summary>
    /// Локатор данного элемента должен использовать атрибут name
    /// </summary>
    /// <param name="webDriver"></param>
    /// <param name="by"></param>

    public DropDown(IWebDriver webDriver, By by)
    {
        _uiElement = new UIElement(webDriver, by);
        //_options = new List<UIElement>();

        _options = new List<string>();

        WaitsHelper _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        foreach (var option in _waitsHelper.WaitForPresenceOfAllElementsLocatedBy(by))
        {
            _options.Add(_uiElement.FindUIElement(By.CssSelector("select>option")));
        }
        
        //WaitsHelper _waitsHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));

        /*
        foreach (var webElement in _waitsHelper.WaitForPresenceOfAllElementsLocatedBy(by))
        {
            UIElement uiElement = new UIElement(webDriver, webElement);
            _uiElements.Add(uiElement);
            _values.Add(uiElement.GetAttribute("name"));
            _texts.Add(uiElement.FindUIElement(By.CssSelector("select>option")).Text);
            _options.Add(uiElement.FindUIElement(By.CssSelector("select>option")));
        }
        */
    }
    /*
    public void SelectByIndex(int index)
    {
        if (index < _uiElement.Count)
        {
            _uiElement[index].Click();
        }
        else
        {
            throw new AssertionException("Превышен индекс");
        }
    }
    */
    /*
    public void SelectByValue(string value)
    {
        _uiElements[_values.IndexOf(value)].Click();
    }
    */
    /*
    public void SelectByText(string text)
    {
        var index = _texts.IndexOf(text);
        _uiElements[index].Click();
    }
*/
    /*
    public void SelectByOption(string text)
    {
        _uiElements[0].Click();
        _txtOptions = GetOptions();
        _options
            .Where(x => _txtOptions.Equals(text))
            .ToList()
            .ForEach(x => x.Click());
    }
    */
    public List<string> GetOptions()
    {
        _txtOptions = new();
        _options.ForEach(x => _txtOptions.Add(x));
        return _txtOptions;
    }
    
}