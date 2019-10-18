namespace Litehtml.Events
{
    /// <summary>
    /// HashChangeEvent
    /// events: onhashchange
    /// </summary>
    public class HashChangeEvent : Event
    {
        /// <summary>
        /// Returns the URL of the document, after the hash has been changed
        /// </summary>
        /// <value>The new URL.</value>
        public string newURL { get; }
        /// <summary>
        /// Returns the URL of the document, before the hash was changed
        /// </summary>
        /// <value>The old URL.</value>
        public string oldURL { get; }
    }
}
