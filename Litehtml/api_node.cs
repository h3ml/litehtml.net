using System;
using System.Collections.Generic;

namespace Litehtml
{
    /// <summary>
    /// Node
    /// https://www.w3schools.com/xml/dom_node.asp
    /// </summary>
    public interface Node
    {
        /// <summary>
        /// Adds a new child node, to an element, as the last child node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        Node appendChild(Node node);

        /// <summary>
        /// Returns a NamedNodeMap of an element's attributes
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        NamedNodeMap<Attr> attributes { get; }

        /// <summary>
        /// Returns the absolute base URI of a node
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        string baseURI { get; } //: Base

        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        NodeList childNodes { get; }

        /// <summary>
        /// Clones an element
        /// </summary>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        Node cloneNode(bool deep = false);

        /// <summary>
        /// Compares the document position of two elements
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        int compareDocumentPosition(Node node);

        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        Node firstChild { get; }

        ///// <summary>
        ///// Returns a DOM object which implements the specialized APIs of the specified feature and version
        ///// </summary>
        ///// <param name="feature">The feature.</param>
        ///// <param name="version">The version.</param>
        ///// <returns></returns>
        //object getFeature(string feature, string version); //: Base

        /// <summary>
        /// Returns the object associated to a key on a this node. The object must first have been set to this node by calling setUserData with the same key
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        string getUserData(string key); //: Base

        /// <summary>
        /// Returns true if an element has the specified attribute, otherwise false
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns>
        ///   <c>true</c> if the specified attributename has attribute; otherwise, <c>false</c>.
        /// </returns>
        bool hasAttribute(string attributename);  //: Node

        /// <summary>
        /// Returns true if an element has any attributes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has attributes; otherwise, <c>false</c>.
        /// </returns>
        bool hasAttributes();

        /// <summary>
        /// Returns true if an element has any child nodes, otherwise false
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has child nodes]; otherwise, <c>false</c>.
        /// </returns>
        bool hasChildNodes();

        /// <summary>
        /// Returns true if a specified namespaceURI is the default, otherwise false
        /// </summary>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <returns>
        ///   <c>true</c> if [is default namespace] [the specified namespace URI]; otherwise, <c>false</c>.
        /// </returns>
        bool isDefaultNamespace(string namespaceURI);

        /// <summary>
        /// Checks if two elements are equal
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is equal node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        bool isEqualNode(Node node);

        /// <summary>
        /// Checks if two elements are the same node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is same node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        bool isSameNode(Node node);

        /// <summary>
        /// Returns the last child node of an element
        /// </summary>
        /// <value>
        /// The last child.
        /// </value>
        Node lastChild { get; }

        /// <summary>
        /// Returns the namespace URI associated with a given prefix
        /// </summary>
        /// <param name="prefix">The prefix.</param>
        /// <returns></returns>
        string lookupNamespaceURI(string prefix); //: Base

        /// <summary>
        /// Returns the prefix associated with a given namespace URI
        /// </summary>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <returns></returns>
        string lookupPrefix(string namespaceURI); //: Base

        /// <summary>
        /// Returns the next node at the same node tree level
        /// </summary>
        /// <value>
        /// The next sibling.
        /// </value>
        Node nextSibling { get; }

        /// <summary>
        /// Returns the name of a node
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        string nodeName { get; }

        /// <summary>
        /// Returns the node type of a node
        /// </summary>
        /// <value>
        /// The type of the node.
        /// </value>
        int nodeType { get; }

        /// <summary>
        /// Sets or returns the value of a node
        /// </summary>
        /// <value>
        /// The node value.
        /// </value>
        string nodeValue { get; set; }

        /// <summary>
        /// Joins adjacent text nodes and removes empty text nodes in an element
        /// </summary>
        void normalize();

        /// <summary>
        /// Returns the root element (document object) for an element
        /// </summary>
        /// <value>
        /// The owner document.
        /// </value>
        Document ownerDocument { get; }

        /// <summary>
        /// Returns the parent node of an element
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        Node parentNode { get; }

        /// <summary>
        /// Sets or returns the namespace prefix of a node
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        string prefix { get; set; } //: Base

        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        Node previousSibling { get; }

        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        Node removeChild(Node node);

        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        Node replaceChild(Node newnode, Node oldnode);

        /// <summary>
        /// Sets the user data.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="data">The data.</param>
        /// <param name="handler">The handler.</param>
        void setUserData(string key, string data, string handler); //: Base

        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        string textContent { get; set; }
    }

    /// <summary>
    /// Attr
    /// https://www.w3schools.com/jsref/dom_obj_attributes.asp
    /// </summary>
    /// <seealso cref="Litehtml.Node" />
    public interface Attr : Node
    {
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
    /// NodeList
    /// https://www.w3schools.com/xml/dom_nodelist.asp
    /// https://www.w3schools.com/js/js_htmldom_nodelist.asp
    /// </summary>
    public class NodeList : List<Node> { }

    /// <summary>
    /// NamedNodeMap
    /// </summary>
    public class NamedNodeMap<TNode>
        where TNode : Node
    {
        /// <summary>
        /// Returns a specified attribute node from a NamedNodeMap
        /// </summary>
        public TNode getNamedItem(string nodename) => throw new NotImplementedException();

        /// <summary>
        /// Gets the <see cref="Node"/> with the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="Node"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public TNode this[int index]
        {
            get => throw new NotImplementedException();
        }
        /// <summary>
        /// Returns the attribute node at a specified index in a NamedNodeMap
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public TNode item(int index) => throw new NotImplementedException();
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
        public TNode removeNamedItem(string nodename) => throw new NotImplementedException();
        /// <summary>
        /// Sets the specified attribute node (by name)
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public TNode setNamedItem(TNode node) => throw new NotImplementedException();
    }

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
