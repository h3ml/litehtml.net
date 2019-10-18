// https://www.w3schools.com/jsref/obj_window.asp
using System.Collections.Generic;

namespace Litehtml.Script
{
    /// <summary>
    /// Interface IWindow
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Returns a Boolean value indicating whether a window has been closed or not
        /// </summary>
        /// <value>
        ///   <c>true</c> if closed; otherwise, <c>false</c>.
        /// </value>
        bool closed { get; }
        /// <summary>
        /// Returns a reference to the Console object, which provides methods for logging information to the browser's console (See Console object)
        /// </summary>
        /// <value>
        /// The console.
        /// </value>
        IConsole console { get; }
        /// <summary>
        /// Sets or returns the default text in the statusbar of a window
        /// </summary>
        /// <value>
        /// The default status.
        /// </value>
        string defaultStatus { get; set; }
        /// <summary>
        /// Returns the Document object for the window (See Document object)
        /// </summary>
        /// <value>
        /// The document.
        /// </value>
        IDocument document { get; }
        /// <summary>
        /// Returns the <iframe> element in which the current window is inserted
        /// </summary>
        /// <value>
        /// The frame element.
        /// </value>
        IElement frameElement { get; }
        /// <summary>
        /// Returns all <iframe> elements in the current window
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        IList<IElement> frames { get; }
        /// <summary>
        /// Returns the History object for the window (See History object)
        /// </summary>
        /// <value>
        /// The history.
        /// </value>
        IHistory history { get; }
        /// <summary>
        /// Returns the height of the window's content area (viewport) including scrollbars
        /// </summary>
        /// <value>
        /// The height of the inner.
        /// </value>
        int innerHeight { get; }
        /// <summary>
        /// Returns the width of a window's content area (viewport) including scrollbars
        /// </summary>
        /// <value>
        /// The width of the inner.
        /// </value>
        int innerWidth { get; }
        /// <summary>
        /// Returns the number of <iframe> elements in the current window
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        int length { get; }
        /// <summary>
        /// Allows to save key/value pairs in a web browser. Stores the data with no expiration date
        /// </summary>
        /// <value>
        /// The local storage.
        /// </value>
        IStorage localStorage { get; }
        /// <summary>
        /// Returns the Location object for the window (See Location object)
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        ILocation location { get; }
        /// <summary>
        /// Sets or returns the name of a window
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string name { get; set; }
        /// <summary>
        /// Returns the Navigator object for the window (See Navigator object)
        /// </summary>
        /// <value>
        /// The navigator.
        /// </value>
        INavigator navigator { get; }
        /// <summary>
        /// Returns a reference to the window that created the window
        /// </summary>
        /// <value>
        /// The opener.
        /// </value>
        IWindow opener { get; }
        /// <summary>
        /// Returns the height of the browser window, including toolbars/scrollbars
        /// </summary>
        /// <value>
        /// The height of the outer.
        /// </value>
        int outerHeight { get; }
        /// <summary>
        /// Returns the width of the browser window, including toolbars/scrollbars
        /// </summary>
        /// <value>
        /// The width of the outer.
        /// </value>
        int outerWidth { get; }
        /// <summary>
        /// Returns the pixels the current document has been scrolled (horizontally) from the upper left corner of the window
        /// </summary>
        /// <value>
        /// The page x offset.
        /// </value>
        int pageXOffset { get; }
        /// <summary>
        /// Returns the pixels the current document has been scrolled (vertically) from the upper left corner of the window
        /// </summary>
        /// <value>
        /// The page y offset.
        /// </value>
        int pageYOffset { get; }
        /// <summary>
        /// Returns the parent window of the current window
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        IWindow parent { get; }
        /// <summary>
        /// Returns the Screen object for the window (See Screen object)
        /// </summary>
        /// <value>
        /// The screen.
        /// </value>
        IScreen screen { get; }
        /// <summary>
        /// Returns the horizontal coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen left.
        /// </value>
        int screenLeft { get; }
        /// <summary>
        /// Returns the vertical coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen top.
        /// </value>
        int screenTop { get; }
        /// <summary>
        /// Returns the horizontal coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen x.
        /// </value>
        int screenX { get; }
        /// <summary>
        /// Returns the vertical coordinate of the window relative to the screen
        /// </summary>
        /// <value>
        /// The screen y.
        /// </value>
        int screenY { get; }
        /// <summary>
        /// Allows to save key/value pairs in a web browser. Stores the data for one session
        /// </summary>
        /// <value>
        /// The session storage.
        /// </value>
        IStorage sessionStorage { get; }
        /// <summary>
        /// An alias of pageXOffset
        /// </summary>
        /// <value>
        /// The scroll x.
        /// </value>
        int scrollX { get; }
        /// <summary>
        /// An alias of pageYOffset
        /// </summary>
        /// <value>
        /// The scroll y.
        /// </value>
        int scrollY { get; }
        /// <summary>
        /// Returns the current window
        /// </summary>
        /// <value>
        /// The self.
        /// </value>
        IWindow self { get; }
        /// <summary>
        /// Sets or returns the text in the statusbar of a window
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        string status { get; set; }
        /// <summary>
        /// Returns the topmost browser window
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        IWindow top { get; }
        /// <summary>
        /// Displays an alert box with a message and an OK button
        /// </summary>
        /// <param name="message">The message.</param>
        void alert(string message);
        /// <summary>
        /// Decodes a base-64 encoded string
        /// </summary>
        /// <param name="encodedStr">The encoded string.</param>
        /// <returns></returns>
        string atob(string encodedStr);
        /// <summary>
        /// Removes focus from the current window
        /// </summary>
        void blur();
        /// <summary>
        /// Encodes a string in base-64
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        string btoa(string str);
        /// <summary>
        /// Clears a timer set with setInterval()
        /// </summary>
        /// <param name="var">The variable.</param>
        void clearInterval(string var);
        /// <summary>
        /// Clears a timer set with setTimeout()
        /// </summary>
        /// <param name="id_of_settimeout">The identifier of settimeout.</param>
        void clearTimeout(string id_of_settimeout);
        /// <summary>
        /// Closes the current window
        /// </summary>
        void close();
        /// <summary>
        /// Displays a dialog box with a message and an OK and a Cancel button
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        bool confirm(string message);
        /// <summary>
        /// Sets focus to the current window
        /// </summary>
        void focus();
        /// <summary>
        /// Gets the current computed CSS styles applied to an element
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="pseudoElement">The pseudo element.</param>
        /// <returns></returns>
        IStyle getComputedStyle(string element, string pseudoElement);
        /// <summary>
        /// Returns a Selection object representing the range of text selected by the user
        /// </summary>
        /// <returns></returns>
        object getSelection();
        /// <summary>
        /// Returns a MediaQueryList object representing the specified CSS media query string
        /// </summary>
        /// <param name="mediaQueryString">The media query string.</param>
        /// <returns></returns>
        MediaQueryList matchMedia(string mediaQueryString);
        /// <summary>
        /// Moves a window relative to its current position
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        void moveBy(int x, int y);
        /// <summary>
        /// Moves a window to the specified position
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        void moveTo(int x, int y);
        /// <summary>
        /// Opens a new browser window
        /// </summary>
        /// <param name="URL">The URL.</param>
        /// <param name="name">The name.</param>
        /// <param name="specs">The specs.</param>
        /// <param name="replace">The replace.</param>
        /// <returns></returns>
        IWindow open(string URL = null, string name = null, string specs = null, bool? replace = null);
        /// <summary>
        /// Prints the content of the current window
        /// </summary>
        void print();
        /// <summary>
        /// Displays a dialog box that prompts the visitor for input
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="defaultText">The default text.</param>
        /// <returns></returns>
        string prompt(string text, string defaultText = null);
        /// <summary>
        /// Requests the browser to call a function to update an animation before the next repaint
        /// </summary>
        /// <returns></returns>
        object requestAnimationFrame();
        /// <summary>
        /// Resizes the window by the specified pixels
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void resizeBy(int width, int height);
        /// <summary>
        /// Resizes the window to the specified width and height
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        void resizeTo(int width, int height);
        /// <summary>
        /// Scrolls the document by the specified number of pixels
        /// </summary>
        /// <param name="xnum">The xnum.</param>
        /// <param name="ynum">The ynum.</param>
        void scrollBy(int xnum, int ynum);
        /// <summary>
        /// Scrolls the document to the specified coordinates
        /// </summary>
        /// <param name="xpos">The xpos.</param>
        /// <param name="ypos">The ypos.</param>
        void scrollTo(int xpos, int ypos);
        /// <summary>
        /// Calls a function or evaluates an expression at specified intervals (in milliseconds)
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        int setInterval(string function, int milliseconds, params object[] args);
        /// <summary>
        /// Calls a function or evaluates an expression after a specified number of milliseconds
        /// </summary>
        /// <param name="function">The function.</param>
        /// <param name="milliseconds">The milliseconds.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        int setTimeout(string function, int milliseconds, params object[] args);
        /// <summary>
        /// Stops the window from loading
        /// </summary>
        void stop();
    }
}
