using Litehtml.Script;
using System;

// https://www.w3schools.com/jsref/obj_event.asp
namespace Litehtml.Events
{
    /// <summary>
    /// Event
    /// </summary>
    public partial class Event
    {
        internal bool _inPassiveListener;
        internal bool _immediatePropagationStopped;

        /// <summary>
        /// Returns whether or not a specific event is a bubbling event
        /// </summary>
        /// <value>
        ///   <c>true</c> if bubbles; otherwise, <c>false</c>.
        /// </value>
        public bool bubbles { get; }
        /// <summary>
        /// Sets or returns whether the event should propagate up the hierarchy or not
        /// </summary>
        /// <value>
        ///   <c>true</c> if [cancel bubble]; otherwise, <c>false</c>.
        /// </value>
        public bool cancelBubble { set => throw new NotImplementedException(); }
        /// <summary>
        /// Returns whether or not an event can have its default action prevented
        /// </summary>
        /// <value>
        ///   <c>true</c> if cancelable; otherwise, <c>false</c>.
        /// </value>
        public bool cancelable { get; }
        /// <summary>
        /// Returns whether the event is composed or not
        /// </summary>
        /// <value>
        ///   <c>true</c> if composed; otherwise, <c>false</c>.
        /// </value>
        public bool composed { get; }
        //public Event createEvent(string type) => throw new NotImplementedException();
        /// <summary>
        /// Returns the event's path
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IElement[] composedPath() => throw new NotImplementedException();
        /// <summary>
        /// Returns the element whose event listeners triggered the event
        /// </summary>
        /// <value>
        /// Returns the element whose event listeners triggered the event
        /// </value>
        public IElement currentTarget { get; }
        /// <summary>
        /// Returns whether or not the preventDefault() method was called for the event
        /// </summary>
        /// <value>
        ///   <c>true</c> if [default prevented]; otherwise, <c>false</c>.
        /// </value>
        public bool defaultPrevented { get; }
        /// <summary>
        /// Returns which phase of the event flow is currently being evaluated
        /// </summary>
        /// <value>
        /// The event phase.
        /// </value>
        public int eventPhase { get; }
        /// <summary>
        /// Returns whether or not an event is trusted
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is trusted; otherwise, <c>false</c>.
        /// </value>
        public bool isTrusted { get; }
        /// <summary>
        /// Cancels the event if it is cancelable, meaning that the default action that belongs to the event will not occur
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void preventDefault() => throw new NotImplementedException();
        /// <summary>
        /// Prevents other listeners of the same event from being called
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void stopImmediatePropagation() => _immediatePropagationStopped = true;
        /// <summary>
        /// Returns the element that triggered the event
        /// </summary>
        /// <value>
        /// The target.
        /// </value>
        public IElement target { get; }
        /// <summary>
        /// Returns the time (in milliseconds relative to the epoch) at which the event was created
        /// </summary>
        /// <value>
        /// The time stamp.
        /// </value>
        public long timeStamp { get; }
        /// <summary>
        /// Returns the name of the event
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string type { get; }
    }
}
