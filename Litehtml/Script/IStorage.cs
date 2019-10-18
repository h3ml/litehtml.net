// https://www.w3schools.com/jsref/obj_storage.asp
namespace Litehtml.Script
{
    /// <summary>
    /// Interface IWebStorage
    /// </summary>
    public interface IStorage
    {
        /// <summary>
        /// Returns the name of the nth key in the storage
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        string key(int index);
        /// <summary>
        /// Returns the number of data items stored in the Storage object
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        int length { get; }
        /// <summary>
        /// Returns the value of the specified key name
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        /// <returns></returns>
        string getItem(string keyname);
        /// <summary>
        /// Adds that key to the storage, or update that key's value if it already exists
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        string setItem(string keyname, string value);
        /// <summary>
        /// Removes that key from the storage
        /// </summary>
        /// <param name="keyname">The keyname.</param>
        void removeItem(string keyname);
        /// <summary>
        /// Empty all key out of the storage
        /// </summary>
        void clear();
    }
}
