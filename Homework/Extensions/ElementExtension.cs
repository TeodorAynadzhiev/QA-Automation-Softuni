using OpenQA.Selenium;

namespace Homework
{    
        public static class ElementExtension
        {
            public static void Type(this IWebElement element, string value)
            {
                element.Clear();
                element.SendKeys(value);
            }
        }    
}
