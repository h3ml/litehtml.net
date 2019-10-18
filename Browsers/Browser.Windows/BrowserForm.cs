using Litehtml;
using Litehtml.Script;
using Litehtml.Services;
using System;
using System.Windows.Forms;

namespace Browser.Windows
{
    public partial class BrowserForm : Form, INavigator
    {
        readonly context _context;
        bool _consoleOpen;

        #region Navigator

        string INavigator.appCodeName => "BrowserForm";
        string INavigator.appName => "BrowserForm";
        string INavigator.appVersion => "1.0";
        bool INavigator.cookieEnabled => false;
        Geolocation INavigator.geolocation => throw new NotImplementedException();
        string INavigator.language => "en";
        bool INavigator.onLine => true;
        string INavigator.platform => "platform";
        string INavigator.product => "product";
        string INavigator.userAgent => WebpageControl.USERAGENT;
        bool INavigator.javaEnabled() => false;

        #endregion

        public BrowserForm()
        {
            _context = new context();
            _consoleOpen = false;
            InitializeComponent();
        }

        public void create()
        {
            var css = Resources.master_css;
            _context.load_master_stylesheet(css);
            _toolbar.create();
            _view.create(_context);
            _console.create();
            OnResize(null);
        }

        void SetSize(int width, int height)
        {
            Width = width; Height = height;
            OnResize(null);
        }

        protected override void OnResize(EventArgs e)
        {
            _toolbar.Height = _toolbar.set_width(Width - 20);
            _console.Visible = _consoleOpen;
            _console.set_width(Width - 20);
            base.OnResize(e);
            Refresh();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12: _consoleOpen = !_consoleOpen; OnResize(null); break;
                default: _view.OnKeyDown(e); break;
            }
            base.OnKeyDown(e);
        }

        public void open(string path) => _view.open(path, true);
        public void back() => _view.back();
        public void forward() => _view.forward();
        public void reload() => _view.refresh();
        public void calc_time(int calc_repeat = 1) => _view.render(true, true, calc_repeat);
        public void on_page_loaded(string url)
        {
            _view.Focus();
            _toolbar.on_page_loaded(url);
            _console.on_page_loaded(url);
        }
    }
}
