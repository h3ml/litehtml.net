// https://www.w3schools.com/jsref/obj_screen.asp
namespace Litehtml.Script
{
    /// <summary>
    /// IScreen
    /// </summary>
    public interface IScreen
    {
        /// <summary>
        /// Returns the height of the screen (excluding the Windows Taskbar)
        /// </summary>
        /// <value>
        /// The height of the avail.
        /// </value>
        int availHeight { get; }
        /// <summary>
        /// Returns the width of the screen (excluding the Windows Taskbar)
        /// </summary>
        /// <value>
        /// The width of the avail.
        /// </value>
        int availWidth { get; }
        /// <summary>
        /// Returns the bit depth of the color palette for displaying images
        /// </summary>
        /// <value>
        /// The color depth.
        /// </value>
        int colorDepth { get; }
        /// <summary>
        /// Returns the total height of the screen
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        int height { get; }
        /// <summary>
        /// Returns the color resolution (in bits per pixel) of the screen
        /// </summary>
        /// <value>
        /// The pixel depth.
        /// </value>
        int pixelDepth { get; }
        /// <summary>
        /// Returns the total width of the screen
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        int width { get; }
    }
}
