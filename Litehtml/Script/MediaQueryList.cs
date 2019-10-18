// https://www.w3schools.com/jsref/met_win_matchmedia.asp
using System;

namespace Litehtml.Script
{
    /// <summary>
    /// MediaQueryList
    /// </summary>
    public class MediaQueryList
    {
        /// <summary>
        /// Used to check the results of a query. Returns a boolean value: true if the document matches the media query list, otherwise false
        /// </summary>
        /// <value>
        /// The matches.
        /// </value>
        public object matches { get; }
        /// <summary>
        /// A String, representing the serialized media query list
        /// </summary>
        /// <value>
        /// The media.
        /// </value>
        public string media { get; }
        /// <summary>
        /// Adds a new listener function, which is executed whenever the media query's evaluated result changes
        /// </summary>
        /// <param name="functionref">The functionref.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void addListener(object functionref) => throw new NotImplementedException();
        /// <summary>
        /// Removes a previously added listener function from the media query list. Does nothing if the specified listener is not already in the list
        /// </summary>
        /// <param name="functionref">The functionref.</param>
        /// <exception cref="NotImplementedException"></exception>
        public void removeListener(object functionref) => throw new NotImplementedException();
    }
}
