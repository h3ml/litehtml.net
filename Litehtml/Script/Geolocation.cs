using System;

// https://www.w3schools.com/jsref/obj_geolocation.asp
namespace Litehtml.Script
{
    /// <summary>
    /// Geolocation
    /// </summary>
    public class Geolocation
    {
        /// <summary>
        /// Returns the position and altitude of the device on Earth
        /// </summary>
        /// <value>The coordinates.</value>
        /// <exception cref="NotImplementedException"></exception>
        public object coordinates => throw new NotImplementedException();
        /// <summary>
        /// Returns the position of the concerned device at a given time
        /// </summary>
        /// <value>The position.</value>
        /// <exception cref="System.NotImplementedException"></exception>
        public object position => throw new NotImplementedException();
        /// <summary>
        /// Returns the reason of an error occurring when using the geolocating device
        /// </summary>
        /// <value>The position error.</value>
        public string positionError { get; }
        /// <summary>
        /// Describes an object containing option properties to pass as a parameter of Geolocation.getCurrentPosition() and Geolocation.watchPosition()
        /// </summary>
        /// <value>The position options.</value>
        public object positionOptions { get; }
        /// <summary>
        /// Unregister location/error monitoring handlers previously installed using Geolocation.watchPosition()
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void clearWatch() => throw new NotImplementedException();
        /// <summary>
        /// Returns the current position of the device
        /// </summary>
        /// <returns>System.Object.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public object getCurrentPosition() => throw new NotImplementedException();
        /// <summary>
        /// Returns a watch ID value that then can be used to unregister the handler by passing it to the Geolocation.clearWatch() method
        /// </summary>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int watchPosition() => throw new NotImplementedException();
    }
}
