namespace Litehtml.Events
{
    /// <summary>
    /// ProgressEvent
    /// events: onerror, onloadstart
    /// </summary>
    public class ProgressEvent : Event
    {
        /// <summary>
        /// Returns whether the length of the progress can be computable or not
        /// </summary>
        /// <value><c>true</c> if [length computable]; otherwise, <c>false</c>.</value>
        public bool lengthComputable { get; }
        /// <summary>
        /// Returns how much work has been loaded
        /// </summary>
        /// <value>The loaded.</value>
        public int loaded { get; }
        /// <summary>
        /// Returns the total amount of work that will be loaded
        /// </summary>
        /// <value>The total.</value>
        public int total { get; }
    }
}
