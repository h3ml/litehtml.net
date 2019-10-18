// https://www.w3schools.com/jsref/dom_obj_style.asp
namespace Litehtml.Script
{
    /// <summary>
    /// Interface IStyle
    /// </summary>
    public interface IStyle
    {
        /// <summary>
        /// Sets or returns the alignment between the lines inside a flexible container when the items do not use all available space
        /// </summary>
        /// <value>The content of the align.</value>
        string alignContent { get; set; }
        /// <summary>
        /// Sets or returns the alignment for items inside a flexible container
        /// </summary>
        /// <value>
        /// The align items.
        /// </value>
        string alignItems { get; set; }
        /// <summary>
        /// Sets or returns the alignment for selected items inside a flexible container
        /// </summary>
        /// <value>
        /// The align self.
        /// </value>
        string alignSelf { get; set; }
        /// <summary>
        /// A shorthand property for all the animation properties below, except the animationPlayState property
        /// </summary>
        /// <value>
        /// The animation.
        /// </value>
        string animation { get; set; }
        /// <summary>
        /// Sets or returns when the animation will start
        /// </summary>
        /// <value>
        /// The animation delay.
        /// </value>
        string animationDelay { get; set; }
        /// <summary>
        /// Sets or returns whether or not the animation should play in reverse on alternate cycles
        /// </summary>
        /// <value>
        /// The animation direction.
        /// </value>
        string animationDirection { get; set; }
        /// <summary>
        /// Sets or returns how many seconds or milliseconds an animation takes to complete one cycle
        /// </summary>
        /// <value>
        /// The duration of the animation.
        /// </value>
        string animationDuration { get; set; }
        /// <summary>
        /// Sets or returns what values are applied by the animation outside the time it is executing
        /// </summary>
        /// <value>
        /// The animation fill mode.
        /// </value>
        string animationFillMode { get; set; }
        /// <summary>
        /// Sets or returns the number of times an animation should be played
        /// </summary>
        /// <value>
        /// The animation iteration count.
        /// </value>
        string animationIterationCount { get; set; }
        /// <summary>
        /// Sets or returns a name for the @keyframes animation
        /// </summary>
        /// <value>
        /// The name of the animation.
        /// </value>
        string animationName { get; set; }
        /// <summary>
        /// Sets or returns the speed curve of the animation
        /// </summary>
        /// <value>
        /// The animation timing function.
        /// </value>
        string animationTimingFunction { get; set; }
        /// <summary>
        /// Sets or returns whether the animation is running or paused
        /// </summary>
        /// <value>
        /// The state of the animation play.
        /// </value>
        string animationPlayState { get; set; }
        /// <summary>
        /// Sets or returns all the background properties in one declaration
        /// </summary>
        /// <value>
        /// The background.
        /// </value>
        string background { get; set; }
        /// <summary>
        /// Sets or returns whether a background-image is fixed or scrolls with the page
        /// </summary>
        /// <value>
        /// The background attachment.
        /// </value>
        string backgroundAttachment { get; set; }
        /// <summary>
        /// Sets or returns the background-color of an element
        /// </summary>
        /// <value>
        /// The color of the background.
        /// </value>
        string backgroundColor { get; set; }
        /// <summary>
        /// Sets or returns the background-image for an element
        /// </summary>
        /// <value>
        /// The background image.
        /// </value>
        string backgroundImage { get; set; }
        /// <summary>
        /// Sets or returns the starting position of a background-image
        /// </summary>
        /// <value>
        /// The background position.
        /// </value>
        string backgroundPosition { get; set; }
        /// <summary>
        /// Sets or returns how to repeat (tile) a background-image
        /// </summary>
        /// <value>
        /// The background repeat.
        /// </value>
        string backgroundRepeat { get; set; }
        /// <summary>
        /// Sets or returns the painting area of the background
        /// </summary>
        /// <value>
        /// The background clip.
        /// </value>
        string backgroundClip { get; set; }
        /// <summary>
        /// Sets or returns the positioning area of the background images
        /// </summary>
        /// <value>
        /// The background origin.
        /// </value>
        string backgroundOrigin { get; set; }
        /// <summary>
        /// Sets or returns the size of the background image
        /// </summary>
        /// <value>
        /// The size of the background.
        /// </value>
        string backgroundSize { get; set; }
        /// <summary>
        /// Sets or returns whether or not an element should be visible when not facing the screen
        /// </summary>
        /// <value>
        /// The backface visibility.
        /// </value>
        string backfaceVisibility { get; set; }
        /// <summary>
        /// Sets or returns borderWidth, borderStyle, and borderColor in one declaration
        /// </summary>
        /// <value>
        /// The border.
        /// </value>
        string border { get; set; }
        /// <summary>
        /// Sets or returns all the borderBottom properties in one declaration
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottom { get; set; }

        /// <summary>
        /// Sets or returns the color of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomColor { get; set; }
        /// <summary>
        /// Sets or returns the shape of the border of the bottom-left corner
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomLeftRadius { get; set; }
        /// <summary>
        /// Sets or returns the shape of the border of the bottom-right corner
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomRightRadius { get; set; }
        /// <summary>
        /// Sets or returns the style of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the bottom border
        /// </summary>
        /// <value>
        /// The border bottom.
        /// </value>
        string borderBottomWidth { get; set; }
        /// <summary>
        /// Sets or returns whether the table border should be collapsed into a single border, or not
        /// </summary>
        /// <value>
        /// The border collapse.
        /// </value>
        string borderCollapse { get; set; }
        /// <summary>
        /// Sets or returns the color of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The color of the border.
        /// </value>
        string borderColor { get; set; }
        /// <summary>
        /// A shorthand property for setting or returning all the borderImage properties
        /// </summary>
        /// <value>
        /// The border image.
        /// </value>
        string borderImage { get; set; }
        /// <summary>
        /// Sets or returns the amount by which the border image area extends beyond the border box
        /// </summary>
        /// <value>
        /// The border image outset.
        /// </value>
        string borderImageOutset { get; set; }
        /// <summary>
        /// Sets or returns whether the image-border should be repeated, rounded or stretched
        /// </summary>
        /// <value>
        /// The border image repeat.
        /// </value>
        string borderImageRepeat { get; set; }
        /// <summary>
        /// Sets or returns the inward offsets of the image-border
        /// </summary>
        /// <value>
        /// The border image slice.
        /// </value>
        string borderImageSlice { get; set; }
        /// <summary>
        /// Sets or returns the image to be used as a border
        /// </summary>
        /// <value>
        /// The border image source.
        /// </value>
        string borderImageSource { get; set; }
        /// <summary>
        /// Sets or returns the widths of the image-border
        /// </summary>
        /// <value>
        /// The width of the border image.
        /// </value>
        string borderImageWidth { get; set; }
        /// <summary>
        /// Sets or returns all the borderLeft properties in one declaration
        /// </summary>
        /// <value>
        /// The border left.
        /// </value>
        string borderLeft { get; set; }
        /// <summary>
        /// Sets or returns the color of the left border
        /// </summary>
        /// <value>
        /// The color of the border left.
        /// </value>
        string borderLeftColor { get; set; }
        /// <summary>
        /// Sets or returns the style of the left border
        /// </summary>
        /// <value>
        /// The border left style.
        /// </value>
        string borderLeftStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the left border
        /// </summary>
        /// <value>
        /// The width of the border left.
        /// </value>
        string borderLeftWidth { get; set; }
        /// <summary>
        /// A shorthand property for setting or returning all the four borderRadius properties
        /// </summary>
        /// <value>
        /// The border radius.
        /// </value>
        string borderRadius { get; set; }
        /// <summary>
        /// Sets or returns all the borderRight properties in one declaration
        /// </summary>
        /// <value>
        /// The border right.
        /// </value>
        string borderRight { get; set; }
        /// <summary>
        /// Sets or returns the color of the right border
        /// </summary>
        /// <value>
        /// The color of the border right.
        /// </value>
        string borderRightColor { get; set; }
        /// <summary>
        /// Sets or returns the style of the right border
        /// </summary>
        /// <value>
        /// The border right style.
        /// </value>
        string borderRightStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the right border
        /// </summary>
        /// <value>
        /// The width of the border right.
        /// </value>
        string borderRightWidth { get; set; }
        /// <summary>
        /// Sets or returns the space between cells in a table
        /// </summary>
        /// <value>
        /// The border spacing.
        /// </value>
        string borderSpacing { get; set; }
        /// <summary>
        /// Sets or returns the style of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The border style.
        /// </value>
        string borderStyle { get; set; }
        /// <summary>
        /// Sets or returns all the borderTop properties in one declaration
        /// </summary>
        /// <value>
        /// The border top.
        /// </value>
        string borderTop { get; set; }
        /// <summary>
        /// Sets or returns the color of the top border
        /// </summary>
        /// <value>
        /// The color of the border top.
        /// </value>
        string borderTopColor { get; set; }
        /// <summary>
        /// Sets or returns the shape of the border of the top-left corner
        /// </summary>
        /// <value>
        /// The border top left radius.
        /// </value>
        string borderTopLeftRadius { get; set; }
        /// <summary>
        /// Sets or returns the shape of the border of the top-right corner
        /// </summary>
        /// <value>
        /// The border top right radius.
        /// </value>
        string borderTopRightRadius { get; set; }
        /// <summary>
        /// Sets or returns the style of the top border
        /// </summary>
        /// <value>
        /// The border top style.
        /// </value>
        string borderTopStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the top border
        /// </summary>
        /// <value>
        /// The width of the border top.
        /// </value>
        string borderTopWidth { get; set; }
        /// <summary>
        /// Sets or returns the width of an element's border (can have up to four values)
        /// </summary>
        /// <value>
        /// The width of the border.
        /// </value>
        string borderWidth { get; set; }
        /// <summary>
        /// Sets or returns the bottom position of a positioned element
        /// </summary>
        /// <value>
        /// The bottom.
        /// </value>
        string bottom { get; set; }
        /// <summary>
        /// Sets or returns the behaviour of the background and border of an element at page-break, or, for in-line elements, at line-break.
        /// </summary>
        /// <value>
        /// The box decoration break.
        /// </value>
        string boxDecorationBreak { get; set; }
        /// <summary>
        /// Attaches one or more drop-shadows to the box
        /// </summary>
        /// <value>
        /// The box shadow.
        /// </value>
        string boxShadow { get; set; }
        /// <summary>
        /// Allows you to define certain elements to fit an area in a certain way
        /// </summary>
        /// <value>
        /// The box sizing.
        /// </value>
        string boxSizing { get; set; }
        /// <summary>
        /// Sets or returns the position of the table caption
        /// </summary>
        /// <value>
        /// The caption side.
        /// </value>
        string captionSide { get; set; }





        /// <summary>
        /// Sets or returns the position of the element relative to floating objects
        /// </summary>
        /// <value>
        /// The clear.
        /// </value>
        string clear { get; set; }
        /// <summary>
        /// Sets or returns which part of a positioned element is visible
        /// </summary>
        /// <value>
        /// The clip.
        /// </value>
        string clip { get; set; }
        /// <summary>
        /// Sets or returns the color of the text
        /// </summary>
        /// <value>
        /// The color.
        /// </value>
        string color { get; set; }
        /// <summary>
        /// Sets or returns the number of columns an element should be divided into
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        string columnCount { get; set; }
        /// <summary>
        /// Sets or returns how to fill columns
        /// </summary>
        /// <value>
        /// The column fill.
        /// </value>
        string columnFill { get; set; }
        /// <summary>
        /// Sets or returns the gap between the columns
        /// </summary>
        /// <value>
        /// The column gap.
        /// </value>
        string columnGap { get; set; }
        /// <summary>
        /// A shorthand property for setting or returning all the columnRule properties
        /// </summary>
        /// <value>
        /// The column rule.
        /// </value>
        string columnRule { get; set; }
        /// <summary>
        /// Sets or returns the color of the rule between columns
        /// </summary>
        /// <value>
        /// The color of the column rule.
        /// </value>
        string columnRuleColor { get; set; }
        /// <summary>
        /// Sets or returns the style of the rule between columns
        /// </summary>
        /// <value>
        /// The column rule style.
        /// </value>
        string columnRuleStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the rule between columns
        /// </summary>
        /// <value>
        /// The width of the column rule.
        /// </value>
        string columnRuleWidth { get; set; }
        /// <summary>
        /// A shorthand property for setting or returning columnWidth and columnCount
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        string columns { get; set; }
        /// <summary>
        /// Sets or returns how many columns an element should span across
        /// </summary>
        /// <value>
        /// The column span.
        /// </value>
        string columnSpan { get; set; }
        /// <summary>
        /// Sets or returns the width of the columns
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        string columnWidth { get; set; }
        /// <summary>
        /// Used with the :before and :after pseudo-elements, to insert generated content
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
        string content { get; set; }
        /// <summary>
        /// Increments one or more counters
        /// </summary>
        /// <value>
        /// The counter increment.
        /// </value>
        string counterIncrement { get; set; }
        /// <summary>
        /// Creates or resets one or more counters
        /// </summary>
        /// <value>
        /// The counter reset.
        /// </value>
        string counterReset { get; set; }
        /// <summary>
        /// Sets or returns the type of cursor to display for the mouse pointer
        /// </summary>
        /// <value>
        /// The cursor.
        /// </value>
        string cursor { get; set; }
        /// <summary>
        /// Sets or returns the text direction
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        string direction { get; set; }
        /// <summary>
        /// Sets or returns an element's display type
        /// </summary>
        /// <value>
        /// The display.
        /// </value>
        string display { get; set; }
        /// <summary>
        /// Sets or returns whether to show the border and background of empty cells, or not
        /// </summary>
        /// <value>
        /// The empty cells.
        /// </value>
        string emptyCells { get; set; }
        /// <summary>
        /// Sets or returns image filters (visual effects, like blur and saturation)
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        string filter { get; set; }
        /// <summary>
        /// Sets or returns the length of the item, relative to the rest
        /// </summary>
        /// <value>
        /// The flex.
        /// </value>
        string flex { get; set; }
        /// <summary>
        /// Sets or returns the initial length of a flexible item
        /// </summary>
        /// <value>
        /// The flex basis.
        /// </value>
        string flexBasis { get; set; }
        /// <summary>
        /// Sets or returns the direction of the flexible items
        /// </summary>
        /// <value>
        /// The flex direction.
        /// </value>
        string flexDirection { get; set; }
        /// <summary>
        /// A shorthand property for the flexDirection and the flexWrap properties
        /// </summary>
        /// <value>
        /// The flex flow.
        /// </value>
        string flexFlow { get; set; }
        /// <summary>
        /// Sets or returns how much the item will grow relative to the rest
        /// </summary>
        /// <value>
        /// The flex grow.
        /// </value>
        string flexGrow { get; set; }
        /// <summary>
        /// Sets or returns how the item will shrink relative to the rest
        /// </summary>
        /// <value>
        /// The flex shrink.
        /// </value>
        string flexShrink { get; set; }
        /// <summary>
        /// Sets or returns whether the flexible items should wrap or not
        /// </summary>
        /// <value>
        /// The flex wrap.
        /// </value>
        string flexWrap { get; set; }
        /// <summary>
        /// Sets or returns the horizontal alignment of an element
        /// </summary>
        /// <value>
        /// The CSS float.
        /// </value>
        string cssFloat { get; set; }
        /// <summary>
        /// Sets or returns fontStyle, fontVariant, fontWeight, fontSize, lineHeight, and fontFamily in one declaration
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        string font { get; set; }
        /// <summary>
        /// Sets or returns the font family for text
        /// </summary>
        /// <value>
        /// The font family.
        /// </value>
        string fontFamily { get; set; }
        /// <summary>
        /// Sets or returns the font size of the text
        /// </summary>
        /// <value>
        /// The size of the font.
        /// </value>
        string fontSize { get; set; }
        /// <summary>
        /// Sets or returns whether the style of the font is normal, italic or oblique
        /// </summary>
        /// <value>
        /// The font style.
        /// </value>
        string fontStyle { get; set; }
        /// <summary>
        /// Sets or returns whether the font should be displayed in small capital letters
        /// </summary>
        /// <value>
        /// The font variant.
        /// </value>
        string fontVariant { get; set; }
        /// <summary>
        /// Sets or returns the boldness of the font
        /// </summary>
        /// <value>
        /// The font weight.
        /// </value>
        string fontWeight { get; set; }
        /// <summary>
        /// Preserves the readability of text when font fallback occurs
        /// </summary>
        /// <value>
        /// The font size adjust.
        /// </value>
        string fontSizeAdjust { get; set; }
        /// <summary>
        /// Selects a normal, condensed, or expanded face from a font family
        /// </summary>
        /// <value>
        /// The font stretch.
        /// </value>
        string fontStretch { get; set; }
        /// <summary>
        /// Specifies whether a punctuation character may be placed outside the line box
        /// </summary>
        /// <value>
        /// The hanging punctuation.
        /// </value>
        string hangingPunctuation { get; set; }
        /// <summary>
        /// Sets or returns the height of an element
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        string height { get; set; }
        /// <summary>
        /// Sets how to split words to improve the layout of paragraphs
        /// </summary>
        /// <value>
        /// The hyphens.
        /// </value>
        string hyphens { get; set; }
        /// <summary>
        /// Provides the author the ability to style an element with an iconic equivalent
        /// </summary>
        /// <value>
        /// The icon.
        /// </value>
        string icon { get; set; }
        /// <summary>
        /// Specifies a rotation in the right or clockwise direction that a user agent applies to an image
        /// </summary>
        /// <value>
        /// The image orientation.
        /// </value>
        string imageOrientation { get; set; }
        /// <summary>
        /// Defines whether an element must create a new stacking content
        /// </summary>
        /// <value>
        /// The isolation.
        /// </value>
        string isolation { get; set; }
        /// <summary>
        /// Sets or returns the alignment between the items inside a flexible container when the items do not use all available space.
        /// </summary>
        /// <value>
        /// The content of the justify.
        /// </value>
        string justifyContent { get; set; }
        /// <summary>
        /// Sets or returns the left position of a positioned element
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        string left { get; set; }
        /// <summary>
        /// Sets or returns the space between characters in a text
        /// </summary>
        /// <value>
        /// The letter spacing.
        /// </value>
        string letterSpacing { get; set; }
        /// <summary>
        /// Sets or returns the distance between lines in a text
        /// </summary>
        /// <value>
        /// The height of the line.
        /// </value>
        string lineHeight { get; set; }
        /// <summary>
        /// Sets or returns listStyleImage, listStylePosition, and listStyleType in one declaration
        /// </summary>
        /// <value>
        /// The list style.
        /// </value>
        string listStyle { get; set; }
        /// <summary>
        /// Sets or returns an image as the list-item marker
        /// </summary>
        /// <value>
        /// The list style image.
        /// </value>
        string listStyleImage { get; set; }
        /// <summary>
        /// Sets or returns the position of the list-item marker
        /// </summary>
        /// <value>
        /// The list style position.
        /// </value>
        string listStylePosition { get; set; }
        /// <summary>
        /// Sets or returns the list-item marker type
        /// </summary>
        /// <value>
        /// The type of the list style.
        /// </value>
        string listStyleType { get; set; }
        /// <summary>
        /// Sets or returns the margins of an element (can have up to four values)
        /// </summary>
        /// <value>
        /// The margin.
        /// </value>
        string margin { get; set; }
        /// <summary>
        /// Sets or returns the bottom margin of an element
        /// </summary>
        /// <value>
        /// The margin bottom.
        /// </value>
        string marginBottom { get; set; }
        /// <summary>
        /// Sets or returns the left margin of an element
        /// </summary>
        /// <value>
        /// The margin left.
        /// </value>
        string marginLeft { get; set; }
        /// <summary>
        /// Sets or returns the right margin of an element
        /// </summary>
        /// <value>
        /// The margin right.
        /// </value>
        string marginRight { get; set; }
        /// <summary>
        /// Sets or returns the top margin of an element
        /// </summary>
        /// <value>
        /// The margin top.
        /// </value>
        string marginTop { get; set; }
        /// <summary>
        /// Sets or returns the maximum height of an element
        /// </summary>
        /// <value>
        /// The maximum height.
        /// </value>
        string maxHeight { get; set; }
        /// <summary>
        /// Sets or returns the maximum width of an element
        /// </summary>
        /// <value>
        /// The maximum width.
        /// </value>
        string maxWidth { get; set; }
        /// <summary>
        /// Sets or returns the minimum height of an element
        /// </summary>
        /// <value>
        /// The minimum height.
        /// </value>
        string minHeight { get; set; }
        /// <summary>
        /// Sets or returns the minimum width of an element
        /// </summary>
        /// <value>
        /// The minimum width.
        /// </value>
        string minWidth { get; set; }
        /// <summary>
        /// Sets or returns where to navigate when using the arrow-down navigation key
        /// </summary>
        /// <value>
        /// The nav down.
        /// </value>
        string navDown { get; set; }
        /// <summary>
        /// Sets or returns the tabbing order for an element
        /// </summary>
        /// <value>
        /// The index of the nav.
        /// </value>
        string navIndex { get; set; }
        /// <summary>
        /// Sets or returns where to navigate when using the arrow-left navigation key
        /// </summary>
        /// <value>
        /// The nav left.
        /// </value>
        string navLeft { get; set; }
        /// <summary>
        /// Sets or returns where to navigate when using the arrow-right navigation key
        /// </summary>
        /// <value>
        /// The nav right.
        /// </value>
        string navRight { get; set; }
        /// <summary>
        /// Sets or returns where to navigate when using the arrow-up navigation key
        /// </summary>
        /// <value>
        /// The nav up.
        /// </value>
        string navUp { get; set; }
        /// <summary>
        /// Specifies how the contents of a replaced element should be fitted to the box established by its used height and width
        /// </summary>
        /// <value>
        /// The object fit.
        /// </value>
        string objectFit { get; set; }
        /// <summary>
        /// Specifies the alignment of the replaced element inside its box
        /// </summary>
        /// <value>
        /// The object position.
        /// </value>
        string objectPosition { get; set; }
        /// <summary>
        /// Sets or returns the opacity level for an element
        /// </summary>
        /// <value>
        /// The opacity.
        /// </value>
        string opacity { get; set; }
        /// <summary>
        /// Sets or returns the order of the flexible item, relative to the rest
        /// </summary>
        /// <value>
        /// The order.
        /// </value>
        string order { get; set; }
        /// <summary>
        /// Sets or returns the minimum number of lines for an element that must be left at the bottom of a page when a page break occurs inside an element
        /// </summary>
        /// <value>
        /// The orphans.
        /// </value>
        string orphans { get; set; }
        /// <summary>
        /// Sets or returns all the outline properties in one declaration
        /// </summary>
        /// <value>
        /// The outline.
        /// </value>
        string outline { get; set; }
        /// <summary>
        /// Sets or returns the color of the outline around a element
        /// </summary>
        /// <value>
        /// The color of the outline.
        /// </value>
        string outlineColor { get; set; }
        /// <summary>
        /// Offsets an outline, and draws it beyond the border edge
        /// </summary>
        /// <value>
        /// The outline offset.
        /// </value>
        string outlineOffset { get; set; }
        /// <summary>
        /// Sets or returns the style of the outline around an element
        /// </summary>
        /// <value>
        /// The outline style.
        /// </value>
        string outlineStyle { get; set; }
        /// <summary>
        /// Sets or returns the width of the outline around an element
        /// </summary>
        /// <value>
        /// The width of the outline.
        /// </value>
        string outlineWidth { get; set; }
        /// <summary>
        /// Sets or returns what to do with content that renders outside the element box
        /// </summary>
        /// <value>
        /// The overflow.
        /// </value>
        string overflow { get; set; }
        /// <summary>
        /// Specifies what to do with the left/right edges of the content, if it overflows the element's content area
        /// </summary>
        /// <value>
        /// The overflow x.
        /// </value>
        string overflowX { get; set; }
        /// <summary>
        /// Specifies what to do with the top/bottom edges of the content, if it overflows the element's content area
        /// </summary>
        /// <value>
        /// The overflow y.
        /// </value>
        string overflowY { get; set; }
        /// <summary>
        /// Sets or returns the padding of an element (can have up to four values)
        /// </summary>
        /// <value>
        /// The padding.
        /// </value>
        string padding { get; set; }
        /// <summary>
        /// Sets or returns the bottom padding of an element
        /// </summary>
        /// <value>
        /// The padding bottom.
        /// </value>
        string paddingBottom { get; set; }
        /// <summary>
        /// Sets or returns the left padding of an element
        /// </summary>
        /// <value>
        /// The padding left.
        /// </value>
        string paddingLeft { get; set; }
        /// <summary>
        /// Sets or returns the right padding of an element
        /// </summary>
        /// <value>
        /// The padding right.
        /// </value>
        string paddingRight { get; set; }
        /// <summary>
        /// Sets or returns the top padding of an element
        /// </summary>
        /// <value>
        /// The padding top.
        /// </value>
        string paddingTop { get; set; }
        /// <summary>
        /// Sets or returns the page-break behavior after an element
        /// </summary>
        /// <value>
        /// The page break after.
        /// </value>
        string pageBreakAfter { get; set; }
        /// <summary>
        /// Sets or returns the page-break behavior before an element
        /// </summary>
        /// <value>
        /// The page break before.
        /// </value>
        string pageBreakBefore { get; set; }
        /// <summary>
        /// Sets or returns the page-break behavior inside an element
        /// </summary>
        /// <value>
        /// The page break inside.
        /// </value>
        string pageBreakInside { get; set; }
        /// <summary>
        /// Sets or returns the perspective on how 3D elements are viewed
        /// </summary>
        /// <value>
        /// The perspective.
        /// </value>
        string perspective { get; set; }
        /// <summary>
        /// Sets or returns the bottom position of 3D elements
        /// </summary>
        /// <value>
        /// The perspective origin.
        /// </value>
        string perspectiveOrigin { get; set; }
        /// <summary>
        /// Sets or returns the type of positioning method used for an element (static, relative, absolute or fixed)
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        string position { get; set; }
        /// <summary>
        /// Sets or returns the type of quotation marks for embedded quotations
        /// </summary>
        /// <value>
        /// The quotes.
        /// </value>
        string quotes { get; set; }
        /// <summary>
        /// Sets or returns whether or not an element is resizable by the user
        /// </summary>
        /// <value>
        /// The resize.
        /// </value>
        string resize { get; set; }
        /// <summary>
        /// Sets or returns the right position of a positioned element
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        string right { get; set; }
        /// <summary>
        /// Sets or returns the way to lay out table cells, rows, and columns
        /// </summary>
        /// <value>
        /// The table layout.
        /// </value>
        string tableLayout { get; set; }
        /// <summary>
        /// Sets or returns the length of the tab-character
        /// </summary>
        /// <value>
        /// The size of the tab.
        /// </value>
        string tabSize { get; set; }
        /// <summary>
        /// Sets or returns the horizontal alignment of text
        /// </summary>
        /// <value>
        /// The text align.
        /// </value>
        string textAlign { get; set; }
        /// <summary>
        /// Sets or returns how the last line of a block or a line right before a forced line break is aligned when text-align is "justify"
        /// </summary>
        /// <value>
        /// The text align last.
        /// </value>
        string textAlignLast { get; set; }
        /// <summary>
        /// Sets or returns the decoration of a text
        /// </summary>
        /// <value>
        /// The text decoration.
        /// </value>
        string textDecoration { get; set; }
        /// <summary>
        /// Sets or returns the color of the text-decoration
        /// </summary>
        /// <value>
        /// The color of the text decoration.
        /// </value>
        string textDecorationColor { get; set; }
        /// <summary>
        /// Sets or returns the type of line in a text-decoration
        /// </summary>
        /// <value>
        /// The text decoration line.
        /// </value>
        string textDecorationLine { get; set; }
        /// <summary>
        /// Sets or returns the style of the line in a text decoration
        /// </summary>
        /// <value>
        /// The text decoration style.
        /// </value>
        string textDecorationStyle { get; set; }
        /// <summary>
        /// Sets or returns the indentation of the first line of text
        /// </summary>
        /// <value>
        /// The text indent.
        /// </value>
        string textIndent { get; set; }
        /// <summary>
        /// Sets or returns the justification method used when text-align is "justify"
        /// </summary>
        /// <value>
        /// The text justify.
        /// </value>
        string textJustify { get; set; }
        /// <summary>
        /// Sets or returns what should happen when text overflows the containing element
        /// </summary>
        /// <value>
        /// The text overflow.
        /// </value>
        string textOverflow { get; set; }
        /// <summary>
        /// Sets or returns the shadow effect of a text
        /// </summary>
        /// <value>
        /// The text shadow.
        /// </value>
        string textShadow { get; set; }
        /// <summary>
        /// Sets or returns the capitalization of a text
        /// </summary>
        /// <value>
        /// The text transform.
        /// </value>
        string textTransform { get; set; }
        /// <summary>
        /// Sets or returns the top position of a positioned element
        /// </summary>
        /// <value>
        /// The top.
        /// </value>
        string top { get; set; }
        /// <summary>
        /// Applies a 2D or 3D transformation to an element
        /// </summary>
        /// <value>
        /// The transform.
        /// </value>
        string transform { get; set; }
        /// <summary>
        /// Sets or returns the position of transformed elements
        /// </summary>
        /// <value>
        /// The transform origin.
        /// </value>
        string transformOrigin { get; set; }
        /// <summary>
        /// Sets or returns how nested elements are rendered in 3D space
        /// </summary>
        /// <value>
        /// The transform style.
        /// </value>
        string transformStyle { get; set; }
        /// <summary>
        /// A shorthand property for setting or returning the four transition properties
        /// </summary>
        /// <value>
        /// The transition.
        /// </value>
        string transition { get; set; }
        /// <summary>
        /// Sets or returns the CSS property that the transition effect is for
        /// </summary>
        /// <value>
        /// The transition property.
        /// </value>
        string transitionProperty { get; set; }
        /// <summary>
        /// Sets or returns how many seconds or milliseconds a transition effect takes to complete
        /// </summary>
        /// <value>
        /// The duration of the transition.
        /// </value>
        string transitionDuration { get; set; }
        /// <summary>
        /// Sets or returns the speed curve of the transition effect
        /// </summary>
        /// <value>
        /// The transition timing function.
        /// </value>
        string transitionTimingFunction { get; set; }
        /// <summary>
        /// Sets or returns when the transition effect will start
        /// </summary>
        /// <value>
        /// The transition delay.
        /// </value>
        string transitionDelay { get; set; }
        /// <summary>
        /// Sets or returns whether the text should be overridden to support multiple languages in the same document
        /// </summary>
        /// <value>
        /// The unicode bidi.
        /// </value>
        string unicodeBidi { get; set; }
        /// <summary>
        /// Sets or returns whether the text of an element can be selected or not
        /// </summary>
        /// <value>
        /// The user select.
        /// </value>
        string userSelect { get; set; }
        /// <summary>
        /// Sets or returns the vertical alignment of the content in an element
        /// </summary>
        /// <value>
        /// The vertical align.
        /// </value>
        string verticalAlign { get; set; }
        /// <summary>
        /// Sets or returns whether an element should be visible
        /// </summary>
        /// <value>
        /// The visibility.
        /// </value>
        string visibility { get; set; }
        /// <summary>
        /// Sets or returns how to handle tabs, line breaks and whitespace in a text
        /// </summary>
        /// <value>
        /// The white space.
        /// </value>
        string whiteSpace { get; set; }
        /// <summary>
        /// Sets or returns the width of an element
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        string width { get; set; }
        /// <summary>
        /// Sets or returns line breaking rules for non-CJK scripts
        /// </summary>
        /// <value>
        /// The word break.
        /// </value>
        string wordBreak { get; set; }
        /// <summary>
        /// Sets or returns the spacing between words in a text
        /// </summary>
        /// <value>
        /// The word spacing.
        /// </value>
        string wordSpacing { get; set; }
        /// <summary>
        /// Allows long, unbreakable words to be broken and wrap to the next line
        /// </summary>
        /// <value>
        /// The word wrap.
        /// </value>
        string wordWrap { get; set; }
        /// <summary>
        /// Sets or returns the minimum number of lines for an element that must be visible at the top of a page
        /// </summary>
        /// <value>
        /// The widows.
        /// </value>
        string widows { get; set; }
        /// <summary>
        /// Sets or returns the stack order of a positioned element
        /// </summary>
        /// <value>
        /// The index of the z.
        /// </value>
        string zIndex { get; set; }
    }
}
