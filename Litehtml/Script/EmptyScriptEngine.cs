namespace Litehtml.Script
{
    public class EmptyScriptEngine : Iscript
    {
        readonly IWindow _window;

        public EmptyScriptEngine(IWindow window)
        {
            _window = window;
        }

        public void LoadFile(string inputFile) { }

        public void addScript(IDocument doc, string function)
        {
        }

        public void addEvent(IElement element, string @event, string function)
        {
            element.addEventListener(@event, function);
        }
    }
}
