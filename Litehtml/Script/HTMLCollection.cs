// https://www.w3schools.com/jsref/dom_obj_htmlcollection.asp
namespace Litehtml.Script
{
    /// <summary>
    /// HTMLCollection
    /// </summary>
    public class HTMLCollection
    {
        /// <summary>
        /// Returns the number of elements in an HTMLCollection
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length { get; }

        /// <summary>
        /// Gets the <see cref="System.Object" /> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="System.Object" />.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public IElement this[int index] => null;

        /// <summary>
        /// Returns the element at the specified index in an HTMLCollection
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public IElement item(int index) => null;

        /// <summary>
        /// Returns the element with the specified ID, or name, in an HTMLCollection
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public IElement namedItem(string name) => null;
    }
}
