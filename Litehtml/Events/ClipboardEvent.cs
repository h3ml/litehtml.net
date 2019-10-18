namespace Litehtml.Events
{
    /// <summary>
    /// ClipboardEvent
    /// events: oncopy, oncut, onpaste
    /// </summary>
    public class ClipboardEvent : Event
    {
        /// <summary>
        /// Returns an object containing the data affected by the clipboard operation
        /// </summary>
        /// <value>The clipboard data.</value>
        public object clipboardData { get; }
    }
}
