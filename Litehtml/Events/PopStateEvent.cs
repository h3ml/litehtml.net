namespace Litehtml.Events
{
    /// <summary>
    /// PopStateEvent
    /// events: popstate
    /// </summary>
    public class PopStateEvent : Event
    {
        /// <summary>
        /// Returns an object containing a copy of the history entries
        /// </summary>
        /// <value>The state.</value>
        public object state { get; }
    }
}
