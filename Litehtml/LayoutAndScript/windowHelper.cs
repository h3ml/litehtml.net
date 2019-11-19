using System;
using System.Collections.Generic;

namespace Litehtml
{
    public class windowHelper
    {
        consoleHelper _console = new consoleHelper();

        public Console console => _console;
        public Element frameElement => throw new NotImplementedException();
        public IList<Element> frames => throw new NotImplementedException();
        public string atob(string encodedStr) => throw new NotImplementedException();
        public string btoa(string str) => throw new NotImplementedException();
        public void clearInterval(string var) => throw new NotImplementedException();
        public void clearTimeout(string id_of_settimeout) => throw new NotImplementedException();
        public Style getComputedStyle(string element, string pseudoElement) => throw new NotImplementedException();
        public object getSelection() => throw new NotImplementedException();
        public MediaQueryList matchMedia(string mediaQueryString) => throw new NotImplementedException();
        public int setInterval(string function, int milliseconds, params object[] args) => throw new NotImplementedException();
        public int setTimeout(string function, int milliseconds, params object[] args) => throw new NotImplementedException();
    }
}
