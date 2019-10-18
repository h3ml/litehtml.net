// https://www.w3schools.com/jsref/dom_obj_attributes.asp
using System;

namespace Litehtml.Script
{
    /// <summary>
    /// IAttr
    /// </summary>
    public interface IAttr
    {
        /// <summary>
        /// Returns true if the attribute is of type Id, otherwise it returns false
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is identifier; otherwise, <c>false</c>.
        /// </value>
        bool isId { get; }
        /// <summary>
        /// Returns the name of an attribute
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string name { get; }
        /// <summary>
        /// Sets or returns the value of the attribute
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        string value { get; set; }
        /// <summary>
        /// Returns true if the attribute has been specified, otherwise it returns false
        /// </summary>
        /// <value>
        ///   <c>true</c> if specified; otherwise, <c>false</c>.
        /// </value>
        bool specified { get; }
    }

    /// <summary>
    /// NamedNodeMap
    /// </summary>
    public class NamedNodeMap
    {
        /// <summary>
        /// Returns a specified attribute node from a NamedNodeMap
        /// </summary>
        public INode getNamedItem(string nodename) => throw new NotImplementedException();

        /// <summary>
        /// Gets the <see cref="INode"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="INode"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public INode this[int index]
        {
            get => throw new NotImplementedException();
        }
        /// <summary>
        /// Returns the attribute node at a specified index in a NamedNodeMap
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public INode item(int index) => throw new NotImplementedException();
        /// <summary>
        /// Returns the number of attribute nodes in a NamedNodeMap
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int length => throw new NotImplementedException();
        /// <summary>
        /// Removes a specified attribute node
        /// </summary>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public INode removeNamedItem(string nodename) => throw new NotImplementedException();
        /// <summary>
        /// Sets the specified attribute node (by name)
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public INode setNamedItem(INode node) => throw new NotImplementedException();
    }
}
