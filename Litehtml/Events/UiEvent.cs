using Litehtml.Script;

namespace Litehtml.Events
{
    /// <summary>
    /// UiEvent
    /// events: abort, beforeunload, error, load, resize, scroll, select, unload
    /// </summary>
    public class UiEvent : Event
    {
        /// <summary>
        /// Returns a number with details about the event
        /// </summary>
        /// <value>The detail.</value>
        public int detail { get; }
        /// <summary>
        /// Returns a reference to the Window object where the event occurred
        /// </summary>
        /// <value>The view.</value>
        public IWindow view { get; }
    }
}
