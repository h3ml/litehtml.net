namespace Litehtml
{
    public interface script_engine
    {
        void addScript(Document doc, string function);
        void addEvent(Element el, string @event, string function);
    }

    public class DefaultScriptEngine : script_engine
    {
        readonly Window _window;

        public DefaultScriptEngine(Window window)
        {
            _window = window;
        }

        public void LoadFile(string inputFile) { }

        public void addScript(Document doc, string function)
        {
        }

        public void addEvent(Element element, string @event, string function)
        {
            element.addEventListener(@event, function);
        }
    }
}
