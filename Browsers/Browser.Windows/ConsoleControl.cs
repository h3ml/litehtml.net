using Litehtml;
using Litehtml.Containers;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Screen = Litehtml.Screen;

namespace Browser.Windows
{
    public partial class ConsoleControl : container_form, Window
    {
        readonly context _context = new context();
        document _doc;
        string _cursor;

        #region Window

        bool Window.closed => throw new System.NotImplementedException();

        Console Window.console => throw new System.NotImplementedException();

        string Window.defaultStatus { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        Document Window.document => throw new System.NotImplementedException();

        Element Window.frameElement => throw new System.NotImplementedException();

        IList<Element> Window.frames => throw new System.NotImplementedException();

        History Window.history => throw new System.NotImplementedException();

        int Window.innerHeight => throw new System.NotImplementedException();

        int Window.innerWidth => throw new System.NotImplementedException();

        int Window.length => throw new System.NotImplementedException();

        Storage Window.localStorage => throw new System.NotImplementedException();

        Location Window.location => throw new System.NotImplementedException();

        string Window.name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        Navigator Window.navigator => throw new System.NotImplementedException();

        Window Window.opener => throw new System.NotImplementedException();

        int Window.outerHeight => throw new System.NotImplementedException();

        int Window.outerWidth => throw new System.NotImplementedException();

        int Window.pageXOffset => throw new System.NotImplementedException();

        int Window.pageYOffset => throw new System.NotImplementedException();

        Window Window.parent => throw new System.NotImplementedException();

        Screen Window.screen => throw new System.NotImplementedException();

        int Window.screenLeft => throw new System.NotImplementedException();

        int Window.screenTop => throw new System.NotImplementedException();

        int Window.screenX => throw new System.NotImplementedException();

        int Window.screenY => throw new System.NotImplementedException();

        Storage Window.sessionStorage => throw new System.NotImplementedException();

        int Window.scrollX => throw new System.NotImplementedException();

        int Window.scrollY => throw new System.NotImplementedException();

        Window Window.self => throw new System.NotImplementedException();

        string Window.status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        Window Window.top => throw new System.NotImplementedException();

        #endregion

        public ConsoleControl()
        {
            InitializeComponent();
        }

        void render_console(int width)
        {
            if (_doc == null)
                return;
            _doc.render(width);
        }

        void update_cursor()
        {
            var defArrow = Cursors.Default;
            if (_cursor == "pointer") Cursor = Cursors.Hand;
            else if (_cursor == "text") Cursor = Cursors.IBeam;
            else Cursor = defArrow;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var cr = CreateGraphics())
            {
                var rect = cr.VisibleClipBounds;
                var clip = new position
                {
                    x = (int)rect.X,
                    y = (int)rect.Y,
                    width = (int)rect.Width,
                    height = (int)rect.Height,
                };
                if (_doc != null)
                    _doc.draw(cr, 0, 0, 0, clip);
            }
        }

        public void create()
        {
            _context.load_master_stylesheet("html,div,body { display: block; } head,style { display: none; }");
            string html;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Browser.Windows.console.console.html"))
            using (var reader = new StreamReader(stream))
                html = reader.ReadToEnd();
            _doc = document.createFromString(html, this, new DefaultScriptEngine(this), _context);
            render_console(Width);
        }

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Browser.Windows.console.{url}"))
                return Image.FromStream(stream);
        }

        public int set_width(int width)
        {
            if (_doc == null)
                return 0;
            render_console(width);
            return _doc.height;
        }

        public void on_page_loaded(string url)
        {
        }

        public override void set_cursor(string cursor) => _cursor = cursor;

        public override void get_client_rect(out position client) => client = new position
        {
            x = Left,
            y = Top,
            width = Width,
            height = Height,
        };

        #region Script

        void Window.alert(string message)
        {
            throw new System.NotImplementedException();
        }

        string Window.atob(string encodedStr)
        {
            throw new System.NotImplementedException();
        }

        void Window.blur()
        {
            throw new System.NotImplementedException();
        }

        string Window.btoa(string str)
        {
            throw new System.NotImplementedException();
        }

        void Window.clearInterval(string var)
        {
            throw new System.NotImplementedException();
        }

        void Window.clearTimeout(string id_of_settimeout)
        {
            throw new System.NotImplementedException();
        }

        void Window.close()
        {
            throw new System.NotImplementedException();
        }

        bool Window.confirm(string message)
        {
            throw new System.NotImplementedException();
        }

        void Window.focus()
        {
            throw new System.NotImplementedException();
        }

        Style Window.getComputedStyle(string element, string pseudoElement)
        {
            throw new System.NotImplementedException();
        }

        object Window.getSelection()
        {
            throw new System.NotImplementedException();
        }

        MediaQueryList Window.matchMedia(string mediaQueryString)
        {
            throw new System.NotImplementedException();
        }

        void Window.moveBy(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        void Window.moveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        Window Window.open(string URL, string name, string specs, bool replace)
        {
            throw new System.NotImplementedException();
        }

        void Window.print()
        {
            throw new System.NotImplementedException();
        }

        string Window.prompt(string text, string defaultText)
        {
            throw new System.NotImplementedException();
        }

        object Window.requestAnimationFrame()
        {
            throw new System.NotImplementedException();
        }

        void Window.resizeBy(int width, int height)
        {
            throw new System.NotImplementedException();
        }

        void Window.resizeTo(int width, int height)
        {
            throw new System.NotImplementedException();
        }

        void Window.scrollBy(int xnum, int ynum)
        {
            throw new System.NotImplementedException();
        }

        void Window.scrollTo(int xpos, int ypos)
        {
            throw new System.NotImplementedException();
        }

        int Window.setInterval(string function, int milliseconds, params object[] args)
        {
            throw new System.NotImplementedException();
        }

        int Window.setTimeout(string function, int milliseconds, params object[] args)
        {
            throw new System.NotImplementedException();
        }

        void Window.stop()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
