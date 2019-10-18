using Litehtml.Script;
using System;

namespace Litehtml.Events
{
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
        public IElement relatedTarget { get; }
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
}
