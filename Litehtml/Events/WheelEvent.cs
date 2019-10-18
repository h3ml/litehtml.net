namespace Litehtml.Events
{
    /// <summary>
    /// WheelEvent
    /// events: onwheel
    /// </summary>
    public class WheelEvent : Event
    {
        /// <summary>
        /// Returns the horizontal scroll amount of a mouse wheel (x-axis)
        /// </summary>
        /// <value>The delta x.</value>
        public int deltaX { get; }
        /// <summary>
        /// Returns the vertical scroll amount of a mouse wheel (y-axis)
        /// </summary>
        /// <value>The delta y.</value>
        public int deltaY { get; }
        /// <summary>
        /// Returns the scroll amount of a mouse wheel for the z-axis
        /// </summary>
        /// <value>The delta z.</value>
        public int deltaZ { get; }
        /// <summary>
        /// Returns a number that represents the unit of measurements for delta values (pixels, lines or pages)
        /// </summary>
        /// <value>The delta mode.</value>
        public int deltaMode { get; }
    }
}
