using Litehtml.Events;
using System;

// https://www.w3schools.com/jsref/dom_obj_document.asp
namespace Litehtml.Script
{
    /// <summary>
    /// IDocument
    /// </summary>
    public interface IDocument
    {
        /// <summary>
        /// Returns the currently focused element in the document
        /// </summary>
        /// <value>
        /// The active element.
        /// </value>
        IElement activeElement { get; }
        /// <summary>
        /// Attaches an event handler to the document
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        void addEventListener(string @event, string function, bool useCapture = false);
        /// <summary>
        /// Adopts a node from another document
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        INode adoptNode(INode node);
        /// <summary>
        /// Returns a collection of all <a> elements in the document that have a name attribute
        /// </summary>
        /// <value>
        /// The anchors.
        /// </value>
        HTMLCollection anchors { get; }
        /// <summary>
        /// Returns a collection of all <applet> elements in the document
        /// </summary>
        /// <value>
        /// The applets.
        /// </value>
        HTMLCollection applets { get; }
        /// <summary>
        /// Returns the absolute base URI of a document
        /// </summary>
        /// <value>
        /// The base URI.
        /// </value>
        string baseURI { get; }
        /// <summary>
        /// Sets or returns the document's body (the <body> element)
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        IElement body { get; set; }
        /// <summary>
        /// Closes the output stream previously opened with document.open()
        /// </summary>
        void close();
        /// <summary>
        /// Returns all name/value pairs of cookies in the document
        /// </summary>
        /// <value>
        /// The cookie.
        /// </value>
        string cookie { get; set;  }
        /// <summary>
        /// Returns the character encoding for the document
        /// </summary>
        /// <value>
        /// The character set.
        /// </value>
        string characterSet { get; }
        /// <summary>
        /// Creates an attribute node
        /// </summary>
        /// <param name="attributename">The attributename.</param>
        /// <returns></returns>
        INode createAttribute(string attributename);
        /// <summary>
        /// Creates a Comment node with the specified text
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        INode createComment(string text); //: IComment
        /// <summary>
        /// Creates an empty DocumentFragment node
        /// </summary>
        /// <returns></returns>
        IDocumentFragment createDocumentFragment();
        /// <summary>
        /// Creates an Element node
        /// </summary>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        IElement createElement(string nodename);
        /// <summary>
        /// Creates a new event
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        Event createEvent(string type);
        /// <summary>
        /// Creates a Text node
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        INode createTextNode(string text); //: IText
        /// <summary>
        /// Returns the window object associated with a document, or null if none is available.
        /// </summary>
        /// <value>
        /// The default view.
        /// </value>
        IWindow defaultView { get; }
        /// <summary>
        /// Controls whether the entire document should be editable or not.
        /// </summary>
        /// <value>
        /// The design mode.
        /// </value>
        string designMode { get; set; } //= "off"
        /// <summary>
        /// Returns the Document Type Declaration associated with the document
        /// </summary>
        /// <value>
        /// The doctype.
        /// </value>
        IDocumentType doctype { get; }
        /// <summary>
        /// Returns the Document Element of the document (the <html> element)
        /// </summary>
        /// <value>
        /// The document element.
        /// </value>
        IElement documentElement { get; }
        /// <summary>
        /// Sets or returns the location of the document
        /// </summary>
        /// <value>
        /// The document URI.
        /// </value>
        string documentURI { get; set; }
        /// <summary>
        /// Returns the domain name of the server that loaded the document
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        string domain { get; }
        /// <summary>
        /// Returns a collection of all <embed> elements the document
        /// </summary>
        /// <value>
        /// The embeds.
        /// </value>
        HTMLCollection embeds { get; }
        /// <summary>
        /// Invokes the specified clipboard operation on the element currently having focus.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="showUI">if set to <c>true</c> [show UI].</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        bool execCommand(string command, bool showUI, object value = null);
        /// <summary>
        /// Returns a collection of all <form> elements in the document
        /// </summary>
        /// <value>
        /// The forms.
        /// </value>
        HTMLCollection forms { get; }
        /// <summary>
        /// Returns the current element that is displayed in fullscreen mode
        /// </summary>
        /// <value>
        /// The fullscreen element.
        /// </value>
        IElement fullscreenElement { get; }
        /// <summary>
        /// Returns a Boolean value indicating whether the document can be viewed in fullscreen mode
        /// </summary>
        /// <returns></returns>
        bool fullscreenEnabled();
        /// <summary>
        /// Returns the element that has the ID attribute with the specified value
        /// </summary>
        /// <param name="elementID">The element identifier.</param>
        /// <returns></returns>
        IElement getElementById(string elementID);
        /// <summary>
        /// Returns a NodeList containing all elements with the specified class name
        /// </summary>
        /// <param name="classname">The classname.</param>
        /// <returns></returns>
        INodeList getElementsByClassName(string classname);
        /// <summary>
        /// Returns a NodeList containing all elements with a specified name
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        INodeList getElementsByName(string name);
        /// <summary>
        /// Returns a NodeList containing all elements with the specified tag name
        /// </summary>
        /// <param name="tagname">The tagname.</param>
        /// <returns></returns>
        INodeList getElementsByTagName(string tagname);
        /// <summary>
        /// Returns a Boolean value indicating whether the document has focus
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has focus; otherwise, <c>false</c>.
        /// </returns>
        bool hasFocus();
        /// <summary>
        /// Returns the <head> element of the document
        /// </summary>
        /// <value>
        /// The head.
        /// </value>
        IElement head { get; }
        /// <summary>
        ///Returns a collection of all <img> elements in the document
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        HTMLCollection images { get; }
        /// <summary>
        /// Returns the DOMImplementation object that handles this document
        /// </summary>
        /// <value>
        /// The implementation.
        /// </value>
        DocumentImplementation implementation { get; }
        /// <summary>
        /// Imports a node from another document
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        INode importNode(INode node, bool deep);
        /// <summary>
        /// Returns the encoding, character set, used for the document
        /// </summary>
        /// <value>
        /// The input encoding.
        /// </value>
        string inputEncoding { get; }
        /// <summary>
        /// Returns the date and time the document was last modified
        /// </summary>
        /// <value>
        /// The last modified.
        /// </value>
        DateTime lastModified { get; } //: string
        /// <summary>
        /// Returns a collection of all <a> and <area> elements in the document that have a href attribute
        /// </summary>
        /// <value>
        /// The links.
        /// </value>
        HTMLCollection links { get; }
        /// <summary>
        /// Removes empty Text nodes, and joins adjacent nodes
        /// </summary>
        void normalize();
        /// <summary>
        /// Opens an HTML output stream to collect output from document.write()
        /// </summary>
        /// <param name="MIMEtype">The mim etype.</param>
        /// <param name="replace">The replace.</param>
        void open(string MIMEtype = null, string replace = null);
        /// <summary>
        /// Returns the first element that matches a specified CSS selector(s) in the document
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        IElement querySelector(string selectors);
        /// <summary>
        /// Returns a static NodeList containing all elements that matches a specified CSS selector(s) in the document
        /// </summary>
        /// <param name="selectors">The selectors.</param>
        /// <returns></returns>
        INodeList querySelectorAll(string selectors);
        /// <summary>
        /// Returns the (loading) status of the document
        /// </summary>
        /// <value>
        /// The state of the ready.
        /// </value>
        string readyState { get; }
        /// <summary>
        /// Returns the URL of the document that loaded the current document
        /// </summary>
        /// <value>
        /// The referrer.
        /// </value>
        string referrer { get; }
        /// <summary>
        /// Removes an event handler from the document (that has been attached with the addEventListener() method)
        /// </summary>
        /// <param name="event">The event.</param>
        /// <param name="function">The function.</param>
        /// <param name="useCapture">if set to <c>true</c> [use capture].</param>
        void removeEventListener(string @event, string function, bool useCapture = false);
        /// <summary>
        /// Renames the specified node
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="namespaceURI">The namespace URI.</param>
        /// <param name="nodename">The nodename.</param>
        /// <returns></returns>
        INode renameNode(INode node, string namespaceURI, string nodename);
        /// <summary>
        /// Returns a collection of <script> elements in the document
        /// </summary>
        /// <value>
        /// The scripts.
        /// </value>
        HTMLCollection scripts { get; }
        /// <summary>
        /// Sets or returns whether error-checking is enforced or not
        /// </summary>
        /// <value>
        ///   <c>true</c> if [strict error checking]; otherwise, <c>false</c>.
        /// </value>
        bool strictErrorChecking { get; set; }
        /// <summary>
        /// Sets or returns the title of the document
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        string title { get; set; }
        /// <summary>
        /// Returns the full URL of the HTML document
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        string URL { get; }
        /// <summary>
        /// Writes HTML expressions or JavaScript code to a document
        /// </summary>
        /// <param name="args">The arguments.</param>
        void write(params object[] args);
        /// <summary>
        /// Same as write(), but adds a newline character after each statement
        /// </summary>
        /// <param name="args">The arguments.</param>
        void writeln(params object[] args);
    }
}
