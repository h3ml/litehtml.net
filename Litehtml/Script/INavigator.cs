// https://www.w3schools.com/jsref/obj_navigator.asp
namespace Litehtml.Script
{
    /// <summary>
    /// INavigator
    /// </summary>
    public interface INavigator
    {
        /// <summary>
        /// Returns the code name of the browser
        /// </summary>
        /// <value>
        /// The name of the application code.
        /// </value>
        string appCodeName { get; }
        /// <summary>
        /// Returns the name of the browser
        /// </summary>
        /// <value>
        /// The name of the application.
        /// </value>
        string appName { get; }
        /// <summary>
        /// Returns the version information of the browser
        /// </summary>
        /// <value>
        /// The application version.
        /// </value>
        string appVersion { get; }
        /// <summary>
        /// Determines whether cookies are enabled in the browser
        /// </summary>
        /// <value>
        ///   <c>true</c> if [cookie enabled]; otherwise, <c>false</c>.
        /// </value>
        bool cookieEnabled { get; }
        /// <summary>
        /// Returns a Geolocation object that can be used to locate the user's position
        /// </summary>
        /// <value>
        /// The geolocation.
        /// </value>
        Geolocation geolocation { get; }
        /// <summary>
        /// Returns the language of the browser
        /// </summary>
        /// <value>
        /// The language.
        /// </value>
        string language { get; }
        /// <summary>
        /// Determines whether the browser is online
        /// </summary>
        /// <value>
        ///   <c>true</c> if [on line]; otherwise, <c>false</c>.
        /// </value>
        bool onLine { get; }
        /// <summary>
        /// Returns for which platform the browser is compiled
        /// </summary>
        /// <value>
        /// The platform.
        /// </value>
        string platform { get; }
        /// <summary>
        /// Returns the engine name of the browser
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        string product { get; }
        /// <summary>
        /// Returns the user-agent header sent by the browser to the server
        /// </summary>
        /// <value>
        /// The user agent.
        /// </value>
        string userAgent { get; }
        /// <summary>
        /// Specifies whether or not the browser has Java enabled
        /// </summary>
        /// <returns></returns>
        bool javaEnabled();
    }
}
