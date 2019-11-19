using System;

namespace Litehtml
{
    /// <summary>
    /// Event
    /// https://www.w3schools.com/jsref/obj_event.asp
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
        public Element[] composedPath() => throw new NotImplementedException();

        /// <summary>
        /// Returns the element whose event listeners triggered the event
        /// </summary>
        /// <value>
        /// Returns the element whose event listeners triggered the event
        /// </value>
        public Element currentTarget { get; }

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
        public Element target { get; }

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

    /// <summary>
    /// UiEvent
    /// events: abort, beforeunload, error, load, resize, scroll, select, unload
    /// </summary>
    public class UiEvent : Event
    {
        /// <summary>
        /// Returns a number with details about the event
        /// </summary>
        /// <value>The detail.</value>
        public int detail { get; }

        /// <summary>
        /// Returns a reference to the Window object where the event occurred
        /// </summary>
        /// <value>The view.</value>
        public Window view { get; }
    }

    /// <summary>
    /// MouseEvent
    /// events: onclick, oncontextmenu, ondblclick, onmousedown, onmouseenter, on mouseleave, onmousemove, onmouseout, onmouseover, onmouseup
    /// </summary>
    public class MouseEvent : UiEvent
    {
        public MouseEvent(string eventType, object window, object platformEvent, int detail, element relatedTarget)
        {
        }

        /// <summary>
        /// Returns whether the "ALT" key was pressed when the mouse event was triggered
        /// </summary>
        /// <value><c>true</c> if [alt key]; otherwise, <c>false</c>.</value>
        public bool altKey { get; }

        /// <summary>
        /// Returns which mouse button was pressed when the mouse event was triggered
        /// </summary>
        /// <value>The button.</value>
        public int button { get; }

        /// <summary>
        /// Returns which mouse buttons were pressed when the mouse event was triggered
        /// </summary>
        /// <value>The buttons.</value>
        public int buttons { get; }

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer, relative to the current window, when the mouse event was triggered
        /// </summary>
        /// <value>The client x.</value>
        public int clientX { get; }

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer, relative to the current window, when the mouse event was triggered
        /// </summary>
        /// <value>The client y.</value>
        public int clientY { get; }

        /// <summary>
        /// Returns whether the "CTRL" key was pressed when the mouse event was triggered
        /// </summary>
        /// <value>The control key.</value>
        public int ctrlKey { get; }

        /// <summary>
        /// Returns true if the specified key is activated
        /// </summary>
        /// <param name="modifierKey">The modifier key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool getModifierState(string modifierKey) => throw new NotImplementedException();

        /// <summary>
        /// Returns whether the "META" key was pressed when an event was triggered
        /// </summary>
        /// <value><c>true</c> if [meta key]; otherwise, <c>false</c>.</value>
        public bool metaKey { get; }

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer relative to the position of the last mousemove event
        /// </summary>
        /// <value>The movement x.</value>
        public int movementX { get; }

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer relative to the position of the last mousemove event
        /// </summary>
        /// <value>The movement y.</value>
        public int movementY { get; }

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer relative to the position of the edge of the target element
        /// </summary>
        /// <value>The offset x.</value>
        public int offsetX { get; }

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer relative to the position of the edge of the target element
        /// </summary>
        /// <value>The offset y.</value>
        public int offsetY { get; }

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer, relative to the document, when the mouse event was triggered
        /// </summary>
        /// <value>The page x.</value>
        public int pageX { get; }

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer, relative to the document, when the mouse event was triggered
        /// </summary>
        /// <value>The page y.</value>
        public int pageY { get; }

        /// <summary>
        /// Gets the region.
        /// </summary>
        /// <value>The region.</value>
        public string region { get; }

        /// <summary>
        /// Returns the element related to the element that triggered the mouse event
        /// </summary>
        /// <value>The related target.</value>
        public Element relatedTarget { get; }

        /// <summary>
        /// Returns the horizontal coordinate of the mouse pointer, relative to the screen, when an event was triggered
        /// </summary>
        /// <value>The screen x.</value>
        public int screenX { get; }

        /// <summary>
        /// Returns the vertical coordinate of the mouse pointer, relative to the screen, when an event was triggered
        /// </summary>
        /// <value>The screen y.</value>
        public int screenY { get; }

        /// <summary>
        /// Returns whether the "SHIFT" key was pressed when an event was triggered
        /// </summary>
        /// <value><c>true</c> if [shift key]; otherwise, <c>false</c>.</value>
        public bool shiftKey { get; }

        /// <summary>
        /// Returns which mouse button was pressed when the mouse event was triggered
        /// </summary>
        /// <value>The which.</value>
        public int which { get; }
    }

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

    /// <summary>
    /// InputEvent
    /// </summary>
    public class InputEvent : Event
    {
        /// <summary>
        /// Returns the inserted characters
        /// </summary>
        /// <value>The data.</value>
        public object data { get; }

        /// <summary>
        /// Returns an object containing information about the inserted/deleted data
        /// </summary>
        /// <value>The data transfer.</value>
        public object dataTransfer { get; }

        /// <summary>
        /// Returns an array containing target ranges that will be affected by the insertion/deletion
        /// </summary>
        /// <returns>System.String[].</returns>
        /// <exception cref="NotImplementedException"></exception>
        public string[] getTargetRanges() => throw new NotImplementedException();

        /// <summary>
        /// Returns the type of the change (i.e "inserting" or "deleting")
        /// </summary>
        /// <value>The type of the input.</value>
        public string inputType { get; }

        /// <summary>
        /// Returns whether the state of the event is composing or not
        /// </summary>
        /// <value>The is composing.</value>
        public string isComposing { get; }
    }

    /// <summary>
    /// KeyboardEvent
    /// events: onkeydown, onkeypress, onkeyup
    /// </summary>
    public class KeyboardEvent : UiEvent
    {
        /// <summary>
        /// Returns whether the "ALT" key was pressed when the key event was triggered
        /// </summary>
        /// <value><c>true</c> if [alt key]; otherwise, <c>false</c>.</value>
        public bool altKey { get; }

        /// <summary>
        /// Returns the Unicode character code of the key that triggered the event
        /// </summary>
        /// <value>The character code.</value>
        public int charCode { get; }

        /// <summary>
        /// Returns the code of the key that triggered the event
        /// </summary>
        /// <value>The code.</value>
        public string code { get; }

        /// <summary>
        /// Returns whether the "CTRL" key was pressed when the key event was triggered
        /// </summary>
        /// <value><c>true</c> if [control key]; otherwise, <c>false</c>.</value>
        public bool ctrlKey { get; }

        /// <summary>
        /// Returns true if the specified key is activated
        /// </summary>
        /// <param name="modifierKey">The modifier key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool getModifierState(string modifierKey) => throw new NotImplementedException();

        /// <summary>
        /// Returns whether the state of the event is composing or not
        /// </summary>
        /// <value><c>true</c> if this instance is composing; otherwise, <c>false</c>.</value>
        public bool isComposing { get; }

        /// <summary>
        /// Returns the key value of the key represented by the event
        /// </summary>
        /// <value>The key.</value>
        public string key { get; }

        /// <summary>
        /// Returns the Unicode character code of the key that triggered the onkeypress event, or the Unicode key code of the key that triggered the onkeydown or onkeyup event
        /// </summary>
        /// <value>The key code.</value>
        public int keyCode { get; }

        /// <summary>
        /// Returns the location of a key on the keyboard or device
        /// </summary>
        /// <value>The location.</value>
        public int location { get; }

        /// <summary>
        /// Returns whether the "meta" key was pressed when the key event was triggered
        /// </summary>
        /// <value><c>true</c> if [meta key]; otherwise, <c>false</c>.</value>
        public bool metaKey { get; }

        /// <summary>
        /// Returns whether a key is being hold down repeatedly, or not
        /// </summary>
        /// <value><c>true</c> if repeat; otherwise, <c>false</c>.</value>
        public bool repeat { get; }

        /// <summary>
        /// Returns whether the "SHIFT" key was pressed when the key event was triggered
        /// </summary>
        /// <value><c>true</c> if [shift key]; otherwise, <c>false</c>.</value>
        public bool shiftKey { get; }

        /// <summary>
        /// Returns the Unicode character code of the key that triggered the onkeypress event, or the Unicode key code of the key that triggered the onkeydown or onkeyup event
        /// </summary>
        /// <value>The which.</value>
        public int which { get; }
    }

    /// <summary>
    /// PageTransitionEvent
    /// events: pagehide, pageshow
    /// </summary>
    public class PageTransitionEvent : Event
    {
        /// <summary>
        /// Returns whether the webpage was cached by the browser
        /// </summary>
        /// <value><c>true</c> if persisted; otherwise, <c>false</c>.</value>
        public bool persisted { get; }
    }

    /// <summary>
    /// PlatformKeyboardEvent
    /// </summary>
    public class PlatformKeyboardEvent
    {
    }

    /// <summary>
    /// PlatformMouseEvent
    /// </summary>
    public class PlatformMouseEvent
    {
    }

    /// <summary>
    /// PlatformWheelEvent
    /// </summary>
    public class PlatformWheelEvent
    {
        public bool deltaX { get; internal set; }
        public bool deltaY { get; internal set; }
    }

    /// <summary>
    /// PopStateEvent
    /// events: popstate
    /// </summary>
    public class PopStateEvent : Event
    {
        /// <summary>
        /// Returns an object containing a copy of the history entries
        /// </summary>
        /// <value>The state.</value>
        public object state { get; }
    }

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

    /// <summary>
    /// StorageEvent
    /// events: storage
    /// </summary>
    public class StorageEvent : Event
    {
        /// <summary>
        /// Returns the key of the changed storage item
        /// </summary>
        /// <value>The key.</value>
        public string key { get; }

        /// <summary>
        /// Returns the new value of the changed storage item
        /// </summary>
        /// <value>The new value.</value>
        public string newValue { get; }

        /// <summary>
        /// Returns the old value of the changed storage item
        /// </summary>
        /// <value>The old value.</value>
        public string oldValue { get; }

        /// <summary>
        /// Returns an object representing the affected storage object
        /// </summary>
        /// <value>The storage area.</value>
        public object storageArea { get; }

        /// <summary>
        /// Returns the URL of the changed item's document
        /// </summary>
        /// <value>The URL.</value>
        public string url { get; }
    }

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
