namespace Litehtml.Events
{
    /// <summary>
    /// StorageEvent
    /// events: storage
    /// </summary>
    public class StorageEvent : Event
    {
        /// <summary>
        /// Returns the key of the changed storage item
        /// </summary>
        /// <value>The key.</value>
        public string key { get; }
        /// <summary>
        /// Returns the new value of the changed storage item
        /// </summary>
        /// <value>The new value.</value>
        public string newValue { get; }
        /// <summary>
        /// Returns the old value of the changed storage item
        /// </summary>
        /// <value>The old value.</value>
        public string oldValue { get; }
        /// <summary>
        /// Returns an object representing the affected storage object
        /// </summary>
        /// <value>The storage area.</value>
        public object storageArea { get; }
        /// <summary>
        /// Returns the URL of the changed item's document
        /// </summary>
        /// <value>The URL.</value>
        public string url { get; }
    }
}
