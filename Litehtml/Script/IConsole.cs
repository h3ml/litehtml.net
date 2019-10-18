// https://www.w3schools.com/jsref/obj_console.asp
namespace Litehtml.Script
{
    /// <summary>
    /// IConsole
    /// </summary>
    public interface IConsole
    {
        /// <summary>
        /// Writes an error message to the console if the assertion is false
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <param name="message">The message.</param>
        void assert(object expression, object message);
        /// <summary>
        /// Clears the console
        /// </summary>
        void clear();
        /// <summary>
        /// Logs the number of times that this particular call to count() has been called
        /// </summary>
        /// <param name="label">The label.</param>
        void count(string label = null);
        /// <summary>
        /// Outputs an error message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        void error(object message);
        /// <summary>
        /// Creates a new inline group in the console. This indents following console messages by an additional level, until console.groupEnd() is called
        /// </summary>
        /// <param name="label">The label.</param>
        void group(string label = null);
        /// <summary>
        /// Creates a new inline group in the console. However, the new group is created collapsed. The user will need to use the disclosure button to expand it
        /// </summary>
        /// <param name="label">The label.</param>
        void groupCollapsed(string label = null);
        /// <summary>
        /// Exits the current inline group in the console
        /// </summary>
        void groupEnd();
        /// <summary>
        /// Outputs an informational message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        void info(object message);
        /// <summary>
        /// Outputs a message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        void log(object message);
        /// <summary>
        /// Displays tabular data as a table
        /// </summary>
        /// <param name="tabledata">The tabledata.</param>
        /// <param name="tablecolumns">The tablecolumns.</param>
        void table(object tabledata, object[] tablecolumns = null);
        /// <summary>
        /// Starts a timer (can track how long an operation takes)
        /// </summary>
        /// <param name="label">The label.</param>
        void time(string label = null);
        /// <summary>
        /// Stops a timer that was previously started by console.time()
        /// </summary>
        /// <param name="label">The label.</param>
        void timeEnd(string label = null);
        /// <summary>
        /// Outputs a stack trace to the console
        /// </summary>
        /// <param name="label">The label.</param>
        void trace(string label = null);
        /// <summary>
        /// Outputs a warning message to the console
        /// </summary>
        /// <param name="message">The message.</param>
        void warn(object message);
    }
}
