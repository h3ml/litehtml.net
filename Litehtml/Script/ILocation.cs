// https://www.w3schools.com/jsref/obj_location.asp
namespace Litehtml.Script
{
    /// <summary>
    /// ILocation
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// Sets or returns the anchor part (#) of a URL
        /// </summary>
        /// <value>
        /// The hash.
        /// </value>
        string hash { get; set; }
        /// <summary>
        /// Sets or returns the hostname and port number of a URL
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        string host { get; set; }
        /// <summary>
        /// Sets or returns the hostname of a URL
        /// </summary>
        /// <value>
        /// The hostname.
        /// </value>
        string hostname { get; set; }
        /// <summary>
        /// Sets or returns the entire URL
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        string href { get; set; }
        /// <summary>
        /// Returns the protocol, hostname and port number of a URL
        /// </summary>
        /// <value>
        /// The origin.
        /// </value>
        string origin { get; }
        /// <summary>
        /// Sets or returns the path name of a URL
        /// </summary>
        /// <value>
        /// The pathname.
        /// </value>
        string pathname { get; set; }
        /// <summary>
        /// Sets or returns the port number of a URL
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        string port { get; set; }
        /// <summary>
        /// Sets or returns the protocol of a URL
        /// </summary>
        /// <value>
        /// The protocol.
        /// </value>
        string protocol { get; set; }
        /// <summary>
        /// Sets or returns the querystring part of a URL
        /// </summary>
        /// <value>
        /// The search.
        /// </value>
        string search { get; set; }
        /// <summary>
        /// Loads a new document
        /// </summary>
        /// <param name="URL">The URL.</param>
        void assign(string URL);
        /// <summary>
        /// Reloads the current document
        /// </summary>
        /// <param name="forceGet">if set to <c>true</c> [force get].</param>
        void reload(bool forceGet = false);
        /// <summary>
        /// Replaces the current document with a new one
        /// </summary>
        /// <param name="newURL">The new URL.</param>
        void replace(string newURL);
    }
}
