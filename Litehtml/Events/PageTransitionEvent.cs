namespace Litehtml.Events
{
    /// <summary>
    /// PageTransitionEvent
    /// events: pagehide, pageshow
    /// </summary>
    public class PageTransitionEvent : Event
    {
        /// <summary>
        /// Returns whether the webpage was cached by the browser
        /// </summary>
        /// <value><c>true</c> if persisted; otherwise, <c>false</c>.</value>
        public bool persisted { get; }
    }
}
