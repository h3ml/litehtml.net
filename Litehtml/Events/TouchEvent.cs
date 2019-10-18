namespace Litehtml.Events
{
    /// <summary>
    /// TouchEvent
    /// events: ontouchcancel, ontouchend, ontouchmove, ontouchstart
    /// </summary>
    public class TouchEvent : UiEvent
    {
        /// <summary>
        /// Returns whether the "ALT" key was pressed when the touch event was triggered
        /// </summary>
        /// <value><c>true</c> if [alt key]; otherwise, <c>false</c>.</value>
        public bool altKey { get; }
        /// <summary>
        /// Returns a list of all the touch objects whose state changed between the previous touch and this touch
        /// </summary>
        /// <value>The changed touched.</value>
        public object[] changedTouched { get; }
        /// <summary>
        /// Returns whether the "CTRL" key was pressed when the touch event was triggered
        /// </summary>
        /// <value><c>true</c> if [control key]; otherwise, <c>false</c>.</value>
        public bool ctrlKey { get; }
        /// <summary>
        /// Returns whether the "meta" key was pressed when the touch event was triggered
        /// </summary>
        /// <value><c>true</c> if [meta key]; otherwise, <c>false</c>.</value>
        public bool metaKey { get; }
        /// <summary>
        /// Returns whether the "SHIFT" key was pressed when the touch event was triggered
        /// </summary>
        /// <value><c>true</c> if [shift key]; otherwise, <c>false</c>.</value>
        public bool shiftKey { get; }
        /// <summary>
        /// Returns a list of all the touch objects that are in contact with the surface and where the touchstart event occured on the same target element as the current target element
        /// </summary>
        /// <value>The target touches.</value>
        public object[] targetTouches { get; }
        /// <summary>
        /// Returns a list of all the touch objects that are currently in contact with the surface
        /// </summary>
        /// <value>The touches.</value>
        public object[] touches { get; }
    }
}
