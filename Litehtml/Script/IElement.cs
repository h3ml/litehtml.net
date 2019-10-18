// https://www.w3schools.com/jsref/dom_obj_all.asp
namespace Litehtml.Script
{
    /// <summary>
    /// IElement
    /// </summary>
    public interface IElement
    {
        /// <summary>
        /// Gets or sets the access key.
        /// </summary>
        /// <value>
        /// The access key.
        /// </value>
        char accessKey { get; set; }
        /// <summary>
        /// Adds the event listener.
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        void addEventListener(string @event, string function, bool useCapture = false);
        /// <summary>
        /// Adds a new child node, to an element, as the last child node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        INode appendChild(INode node);
        /// <summary>
        /// Returns a NamedNodeMap of an element's attributes
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        NamedNodeMap attributes { get; }
        /// <summary>
        /// Removes focus from an element
        /// </summary>
        void blur();
        /// <summary>
        /// Returns the number of child elements an element has
        /// </summary>
        /// <value>
        /// The child element count.
        /// </value>
        int childElementCount { get; }
        /// <summary>
        /// Returns a collection of an element's child nodes (including text and comment nodes)
        /// </summary>
        INodeList childNodes { get; }
        /// <summary>
        /// Returns a collection of an element's child element (excluding text and comment nodes)
        /// </summary>
        HTMLCollection children { get; }
        /// <summary>
        /// Returns the class name(s) of an element
        /// </summary>
        /// <value>
        /// The class list.
        /// </value>
        DOMTokenList classList { get; }
        /// <summary>
        /// Sets or returns the value of the class attribute of an element
        /// </summary>
        /// <value>
        /// The name of the class.
        /// </value>
        string className { get; set; }
        /// <summary>
        /// Simulates a mouse-click on an element
        /// </summary>
        void click();
        /// <summary>
        /// Returns the height of an element, including padding
        /// </summary>
        /// <value>
        /// The height of the client.
        /// </value>
        int clientHeight { get; }
        /// <summary>
        /// Returns the width of the left border of an element
        /// </summary>
        /// <value>
        /// The client left.
        /// </value>
        int clientLeft { get; }
        /// <summary>
        /// Returns the width of the top border of an element
        /// </summary>
        /// <value>
        /// The client top.
        /// </value>
        int clientTop { get; }
        /// <summary>
        /// Returns the width of an element, including padding
        /// </summary>
        /// <value>
        /// The width of the client.
        /// </value>
        int clientWidth { get; }
        /// <summary>
        /// Clones an element
        /// </summary>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        INode cloneNode(bool deep = false);
        /// <summary>
        /// Compares the document position of two elements
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        int compareDocumentPosition(INode node);
        /// <summary>
        /// Returns true if a node is a descendant of a node, otherwise false
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        bool contains(INode node);
        /// <summary>
        /// Sets or returns whether the content of an element is editable or not
        /// </summary>
        /// <value>
        /// The content editable.
        /// </value>
        string contentEditable { get; set; }
        /// <summary>
        /// Sets or returns the value of the dir attribute of an element
        /// </summary>
        /// <value>
        /// The dir.
        /// </value>
        string dir { get; set; }
        /// <summary>
        /// Cancels an element in fullscreen mode
        /// </summary>
        void exitFullscreen();
        /// <summary>
        /// Returns the first child node of an element
        /// </summary>
        /// <value>
        /// The first child.
        /// </value>
        INode firstChild { get; }
        /// <summary>
        /// Returns the first child element of an element
        /// </summary>
        /// <value>
        /// The first element child.
        /// </value>
        INode firstElementChild { get; }
        /// <summary>
        /// Gives focus to an element
        /// </summary>
        void focus();
        /// <summary>
        /// Returns the specified attribute value of an element node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        string getAttribute(string attributename);
        /// <summary>
        /// Returns the specified attribute node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        IAttr getAttributeNode(string attributename);
        /// <summary>
        /// Returns the size of an element and its position relative to the viewport
        /// </summary>
        /// <returns></returns>
        IRect getBoundingClientRect();
        /// <summary>
        /// Returns a collection of all child elements with the specified class name
        /// </summary>
        /// <param name="classname">The classname.</param>
        /// <returns></returns>
        INodeList getElementsByClassName(string classname);
        /// <summary>
        /// Returns a collection of all child elements with the specified tag name
        /// </summary>
        /// <param name="tagname">The tagname.</param>
        /// <returns></returns>
        INodeList getElementsByTagName(string tagname);
        /// <summary>
        /// Returns true if an element has the specified attribute, otherwise false
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns>
        ///   <c>true</c> if the specified attributename has attribute; otherwise, <c>false</c>.
        /// </returns>
        bool hasAttribute(string attributename);
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
        /// Sets or returns the value of the id attribute of an element
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string id { get; set; }
        /// <summary>
        /// Sets or returns the content of an element
        /// </summary>
        /// <value>
        /// The inner HTML.
        /// </value>
        string innerHTML { get; set; }
        /// <summary>
        /// Sets or returns the text content of a node and its descendants
        /// </summary>
        /// <value>
        /// The inner text.
        /// </value>
        string innerText { get; set; }
        /// <summary>
        /// Inserts a HTML element at the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="element">The element.</param>
        void insertAdjacentElement(string position, IElement element);
        /// <summary>
        /// Inserts a HTML formatted text at the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="text">The text.</param>
        void insertAdjacentHTML(string position, string text);
        /// <summary>
        /// Inserts text into the specified position relative to the current element
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="text">The text.</param>
        void insertAdjacentText(string position, string text);
        /// <summary>
        /// Inserts a new child node before a specified, existing, child node
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="existingnode">The existingnode.</param>
        INode insertBefore(INode newnode, INode existingnode);
        /// <summary>
        /// Returns true if the content of an element is editable, otherwise false
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is content editable; otherwise, <c>false</c>.
        /// </value>
        bool isContentEditable { get; }
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
        bool isEqualNode(INode node);
        /// <summary>
        /// Checks if two elements are the same node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>
        ///   <c>true</c> if [is same node] [the specified node]; otherwise, <c>false</c>.
        /// </returns>
        bool isSameNode(INode node);
        /// <summary>
        /// Sets or returns the value of the lang attribute of an element
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        string lang { get; set; }
        /// <summary>
        /// Returns the last child node of an element
        /// </summary>
        /// <value>
        /// The last child.
        /// </value>
        INode lastChild { get; }
        /// <summary>
        /// Returns the last child element of an element
        /// </summary>
        /// <value>
        /// The last element child.
        /// </value>
        INode lastElementChild { get; }
        /// <summary>
        /// Returns the namespace URI of an element
        /// </summary>
        /// <value>
        /// The namespace URI.
        /// </value>
        string namespaceURI { get; }
        /// <summary>
        /// Returns the next node at the same node tree level
        /// </summary>
        /// <value>
        /// The next sibling.
        /// </value>
        INode nextSibling { get; }
        /// <summary>
        /// Returns the next element at the same node tree level
        /// </summary>
        /// <value>
        /// The next element sibling.
        /// </value>
        INode nextElementSibling { get; }
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
        /// Returns the height of an element, including padding, border and scrollbar
        /// </summary>
        /// <value>
        /// The height of the offset.
        /// </value>
        int offsetHeight { get; }
        /// <summary>
        /// Returns the width of an element, including padding, border and scrollbar
        /// </summary>
        /// <value>
        /// The width of the offset.
        /// </value>
        int offsetWidth { get; }
        /// <summary>
        /// Returns the horizontal offset position of an element
        /// </summary>
        /// <value>
        /// The offset left.
        /// </value>
        int offsetLeft { get; }
        /// <summary>
        /// Returns the offset container of an element
        /// </summary>
        /// <value>
        /// The offset parent.
        /// </value>
        INode offsetParent { get; }
        /// <summary>
        /// Returns the vertical offset position of an element
        /// </summary>
        /// <value>
        /// The offset top.
        /// </value>
        int offsetTop { get; }
        /// <summary>
        /// Returns the root element (document object) for an element
        /// </summary>
        /// <value>
        /// The owner document.
        /// </value>
        IDocument ownerDocument { get; }
        /// <summary>
        /// Returns the parent node of an element
        /// </summary>
        /// <value>
        /// The parent node.
        /// </value>
        INode parentNode { get; }
        /// <summary>
        /// Returns the parent element node of an element
        /// </summary>
        /// <value>
        /// The parent element.
        /// </value>
        IElement parentElement { get; }
        /// <summary>
        /// Returns the previous node at the same node tree level
        /// </summary>
        /// <value>
        /// The previous sibling.
        /// </value>
        INode previousSibling { get; }
        /// <summary>
        /// Returns the previous element at the same node tree level
        /// </summary>
        /// <value>
        /// The previous element sibling.
        /// </value>
        INode previousElementSibling { get; }
        /// <summary>
        /// Returns the first child element that matches a specified CSS selector(s) of an element
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        IElement querySelector(string selectors);
        /// <summary>
        /// Returns all child elements that matches a specified CSS selector(s) of an element
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        INodeList querySelectorAll(string selectors);
        /// <summary>
        /// Removes a specified attribute from an element
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        void removeAttribute(string attributename);
        /// <summary>
        /// Removes a specified attribute node, and returns the removed node
        /// </summary>
        /// <param name="attributenode">The attributenode.</param>
        /// <returns></returns>
        IAttr removeAttributeNode(IAttr attributenode);
        /// <summary>
        /// Removes a child node from an element
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        INode removeChild(INode node);
        /// <summary>
        /// Removes an event handler that has been attached with the addEventListener() method
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        void removeEventListener(string @event, string function, bool useCapture = false);
        /// <summary>
        /// Replaces a child node in an element
        /// </summary>
        /// <param name="newnode">The newnode.</param>
        /// <param name="oldnode">The oldnode.</param>
        /// <returns></returns>
        INode replaceChild(INode newnode, INode oldnode);
        /// <summary>
        /// Shows an element in fullscreen mode
        /// </summary>
        void requestFullscreen();
        /// <summary>
        /// Returns the entire height of an element, including padding
        /// </summary>
        /// <value>
        /// The height of the scroll.
        /// </value>
        int scrollHeight { get; }
        /// <summary>
        /// Scrolls the specified element into the visible area of the browser window
        /// </summary>
        /// <param name="alignTo">The align to.</param>
        void scrollIntoView(bool? alignTo = false);
        /// <summary>
        /// Sets or returns the number of pixels an element's content is scrolled horizontally
        /// </summary>
        /// <value>
        /// The scroll left.
        /// </value>
        int scrollLeft { get; }
        /// <summary>
        /// Sets or returns the number of pixels an element's content is scrolled vertically
        /// </summary>
        /// <value>
        /// The scroll top.
        /// </value>
        int scrollTop { get; }
        /// <summary>
        /// Returns the entire width of an element, including padding
        /// </summary>
        /// <value>
        /// The width of the scroll.
        /// </value>
        int scrollWidth { get; }
        /// <summary>
        /// Sets or changes the specified attribute, to the specified value
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <param name="attributevalue">The attributevalue.</param>
        void setAttribute(string attributename, string attributevalue);
        /// <summary>
        /// Sets or changes the specified attribute node
        /// </summary>
        /// <param name="attributenode">The attributenode.</param>
        /// <returns></returns>
        IAttr setAttributeNode(IAttr attributenode);
        /// <summary>
        /// Sets or returns the value of the style attribute of an element
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        IStyle style { get;  }
        /// <summary>
        /// Sets or returns the value of the tabindex attribute of an element
        /// </summary>
        /// <value>
        /// The index of the tab.
        /// </value>
        int tabIndex { get; set; }
        /// <summary>
        /// Returns the tag name of an element
        /// </summary>
        /// <value>
        /// The name of the tag.
        /// </value>
        string tagName { get; }
        /// <summary>
        /// Sets or returns the textual content of a node and its descendants
        /// </summary>
        /// <value>
        /// The content of the text.
        /// </value>
        string textContent { get; set; }
        /// <summary>
        /// Sets or returns the value of the title attribute of an element
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string title { get; set; }
        /// <summary>
        /// Converts an element to a string
        /// </summary>
        void toString();
    }
}
