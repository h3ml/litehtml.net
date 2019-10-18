namespace Litehtml.Script
{
    public interface Iscript
    {
        void addScript(IDocument doc, string function);
        void addEvent(IElement el, string @event, string function);
    }
}
