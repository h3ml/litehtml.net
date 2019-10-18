namespace Litehtml.Script
{
    /// <summary>
    /// DOMTokenList
    /// </summary>
    public class DOMTokenList
    {
        /// <summary>
        /// Returns the number of classes in the list.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length { get; }
        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        /// <param name="classes">The classes.</param>
        public void add(params string[] classes) { }
        /// <summary>
        /// Returns a Boolean value, indicating whether an element has the specified class name.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified class]; otherwise, <c>false</c>.
        /// </returns>
        public bool contains(string @class) => false;
        /// <summary>
        /// Returns the class name with a specified index number from an element
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public string item(int index) => null;
        /// <summary>
        /// Removes one or more class names from an element.
        /// </summary>
        /// <param name="classes">The classes.</param>
        public void remove(params string[] classes) { }
        /// <summary>
        /// Toggles between a class name for an element.
        /// </summary>
        /// <param name="class">The class.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public void toggle(string @class, bool value) { }
    }
}
