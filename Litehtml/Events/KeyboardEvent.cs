using System;

namespace Litehtml.Events
{
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
}
