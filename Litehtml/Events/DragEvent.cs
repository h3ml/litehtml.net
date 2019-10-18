namespace Litehtml.Events
{
    /// <summary>
    /// DragEvent
    /// events: ondrag, ondragend, ondragenter, ondragleave, ondragover, ondragstart, ondrop
    /// </summary>
    public class DragEvent : MouseEvent
    {
        public DragEvent(string eventType, object window, object platformEvent, int detail, element relatedTarget) : base(eventType, window, platformEvent, detail, relatedTarget)
        {
        }

        /// <summary>
        /// Returns the data that is dragged/dropped
        /// </summary>
        /// <value>The data transfer.</value>
        public object dataTransfer { get; }
    }
}
