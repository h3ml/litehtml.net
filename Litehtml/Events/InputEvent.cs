using System;

namespace Litehtml.Events
{
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
}
