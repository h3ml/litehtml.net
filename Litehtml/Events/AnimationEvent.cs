namespace Litehtml.Events
{
    /// <summary>
    /// AnimationEvent
    /// events: animationend, animationiteration, animationstart
    /// </summary>
    public class AnimationEvent : Event
    {
        /// <summary>
        /// Returns the name of the animation
        /// </summary>
        /// <value>The name of the animation.</value>
        public string animationName { get; }

        /// <summary>
        /// Returns the number of seconds an animation has been running
        /// </summary>
        /// <value>The elapsed time.</value>
        public int elapsedTime { get; }

        /// <summary>
        /// Returns the name of the pseudo-element of the animation
        /// </summary>
        /// <value>The pseudo element.</value>
        public string pseudoElement { get; }
    }
}
