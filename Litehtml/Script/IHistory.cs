// https://www.w3schools.com/jsref/obj_history.asp
namespace Litehtml.Script
{
    /// <summary>
    /// Interface IHistory
    /// </summary>
    public interface IHistory
    {
        /// <summary>
        /// Returns the number of URLs in the history list
        /// </summary>
        int length { get; }
        /// <summary>
        /// Loads the previous URL in the history list
        /// </summary>
        void back();
        /// <summary>
        /// Loads the next URL in the history list
        /// </summary>
        void forward();
        /// <summary>
        /// Loads the next URL in the history list
        /// </summary>
        void go(int numberURL);
    }
}
