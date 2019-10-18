namespace Litehtml.Events
{
    /// <summary>
    /// FocusEvent
    /// events: onblur, onfocus, onfocusin, onfocusout
    /// </summary>
    public class FocusEvent : UiEvent
    {
        /// <summary>
        /// Returns the element related to the element that triggered the event
        /// </summary>
        /// <value>The related target.</value>
        public object relatedTarget { get; }
    }
}
