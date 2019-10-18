using Litehtml;
using Litehtml.Containers;
using Litehtml.Script;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Browser.Unity
{
    public class ConsoleControl : container_unity, IWindow
    {
        readonly context _context = new context();
        document _doc;
        string _cursor;
        Vector3 _size;

        #region Window

        bool IWindow.closed => throw new System.NotImplementedException();

        IConsole IWindow.console => throw new System.NotImplementedException();

        string IWindow.defaultStatus { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        IDocument IWindow.document => throw new System.NotImplementedException();

        IElement IWindow.frameElement => throw new System.NotImplementedException();

        IList<IElement> IWindow.frames => throw new System.NotImplementedException();

        IHistory IWindow.history => throw new System.NotImplementedException();

        int IWindow.innerHeight => throw new System.NotImplementedException();

        int IWindow.innerWidth => throw new System.NotImplementedException();

        int IWindow.length => throw new System.NotImplementedException();

        IStorage IWindow.localStorage => throw new System.NotImplementedException();

        ILocation IWindow.location => throw new System.NotImplementedException();

        string IWindow.name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        INavigator IWindow.navigator => throw new System.NotImplementedException();

        IWindow IWindow.opener => throw new System.NotImplementedException();

        int IWindow.outerHeight => throw new System.NotImplementedException();

        int IWindow.outerWidth => throw new System.NotImplementedException();

        int IWindow.pageXOffset => throw new System.NotImplementedException();

        int IWindow.pageYOffset => throw new System.NotImplementedException();

        IWindow IWindow.parent => throw new System.NotImplementedException();

        IScreen IWindow.screen => throw new System.NotImplementedException();

        int IWindow.screenLeft => throw new System.NotImplementedException();

        int IWindow.screenTop => throw new System.NotImplementedException();

        int IWindow.screenX => throw new System.NotImplementedException();

        int IWindow.screenY => throw new System.NotImplementedException();

        IStorage IWindow.sessionStorage => throw new System.NotImplementedException();

        int IWindow.scrollX => throw new System.NotImplementedException();

        int IWindow.scrollY => throw new System.NotImplementedException();

        IWindow IWindow.self => throw new System.NotImplementedException();

        string IWindow.status { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        IWindow IWindow.top => throw new System.NotImplementedException();

        #endregion

        protected virtual void Start()
        {
            _size = new Vector3(500, 500, 10);
        }

        void render_console(int width)
        {
            if (_doc == null)
                return;
            _doc.render(width);
        }

        void update_cursor()
        {
            //var defArrow = Cursors.Default;
            //if (_cursor == "pointer") Cursor = Cursors.Hand;
            //else if (_cursor == "text") Cursor = Cursors.IBeam;
            //else Cursor = defArrow;
        }

        protected override void OnPaint()
        {
            var cr = gameObject;
            var pos = new position
            {
                width = (int)_size.x,
                height = (int)_size.y,
                depth = (int)_size.z,
                x = 0,
                y = 0,
                z = 0,
            };
            if (_doc != null)
                _doc.draw(cr, 0, 0, 0, pos);
        }

        public void create()
        {
            _context.load_master_stylesheet("html,div,body { display: block; } head,style { display: none; }");
            string html;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Browser.Unity.console.console.html"))
            using (var reader = new StreamReader(stream))
                html = reader.ReadToEnd();
            _doc = document.createFromString(html, this, new EmptyScriptEngine(this), _context);
            render_console((int)_size.x);
        }

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Browser.Unity.console.{url}"))
            {
                var m = new MemoryStream();
                stream.CopyTo(m);
                var tex = new Texture2D(1, 1);
                var loaded = tex.LoadImage(m.ToArray());
                if (!loaded)
                    Debug.Log("get_image: !loaded");
                return tex;
            }
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
            width = (int)_size.x,
            height = (int)_size.y,
            depth = (int)_size.z,
            x = 0,
            y = 0,
            z = 0,
        };

        #region Script

        void IWindow.alert(string message)
        {
            throw new System.NotImplementedException();
        }

        string IWindow.atob(string encodedStr)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.blur()
        {
            throw new System.NotImplementedException();
        }

        string IWindow.btoa(string str)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.clearInterval(string var)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.clearTimeout(string id_of_settimeout)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.close()
        {
            throw new System.NotImplementedException();
        }

        bool IWindow.confirm(string message)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.focus()
        {
            throw new System.NotImplementedException();
        }

        IStyle IWindow.getComputedStyle(string element, string pseudoElement)
        {
            throw new System.NotImplementedException();
        }

        object IWindow.getSelection()
        {
            throw new System.NotImplementedException();
        }

        MediaQueryList IWindow.matchMedia(string mediaQueryString)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.moveBy(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.moveTo(int x, int y)
        {
            throw new System.NotImplementedException();
        }

        IWindow IWindow.open(string URL, string name, string specs, bool? replace)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.print()
        {
            throw new System.NotImplementedException();
        }

        string IWindow.prompt(string text, string defaultText)
        {
            throw new System.NotImplementedException();
        }

        object IWindow.requestAnimationFrame()
        {
            throw new System.NotImplementedException();
        }

        void IWindow.resizeBy(int width, int height)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.resizeTo(int width, int height)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.scrollBy(int xnum, int ynum)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.scrollTo(int xpos, int ypos)
        {
            throw new System.NotImplementedException();
        }

        int IWindow.setInterval(string function, int milliseconds, params object[] args)
        {
            throw new System.NotImplementedException();
        }

        int IWindow.setTimeout(string function, int milliseconds, params object[] args)
        {
            throw new System.NotImplementedException();
        }

        void IWindow.stop()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
