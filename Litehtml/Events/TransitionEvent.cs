namespace Litehtml.Events
{
    /// <summary>
    /// TransitionEvent
    /// events: transitionend
    /// </summary>
    public class TransitionEvent : Event
    {
        /// <summary>
        /// Returns the name of the transition
        /// </summary>
        /// <value>The name of the property.</value>
        public string propertyName { get; }
        /// <summary>
        /// Returns the number of seconds a transition has been running
        /// </summary>
        /// <value>The elapsed time.</value>
        public int elapsedTime { get; }
        /// <summary>
        /// Returns the name of the pseudo-element of the transition
        /// </summary>
        /// <value>The pseudo element.</value>
        public string pseudoElement { get; }
    }
}
