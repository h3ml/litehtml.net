using Litehtml;
using Litehtml.Containers;
using Litehtml.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Browser.Windows
{
    public partial class HtmlControl : container_form
    {
        internal const string USERAGENT = "litebrowser/1.0";
        internal const string USERAGENT2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
        HttpService _http = new HttpService(USERAGENT);
        string _url;
        string _base_url;
        document _html;
        context _context;
        int _rendered_width;
        string _cursor;
        string _clicked_url;

        public HtmlControl()
        {
            InitializeComponent();
        }

        public void Set(context context) => _context = context;

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var cr = CreateGraphics())
            {
                var rect = cr.VisibleClipBounds;
                var pos = new position
                {
                    width = (int)rect.Width,
                    height = (int)rect.Height,
                    x = (int)rect.X,
                    y = (int)rect.Y
                };
                if (_html != null)
                    _html.draw(cr, 0, 0, 0, pos);
            }
        }

        public override void get_client_rect(out position client) => client = new position
        {
            width = Width,
            height = Height,
            x = 0,
            y = 0
        };

        public override void on_anchor_click(string url, element el)
        {
            if (url != null)
                make_url(url, _base_url, out _clicked_url);
        }

        public override void set_cursor(string cursor)
        {
            if (cursor != null && _cursor != cursor)
            {
                _cursor = cursor;
                update_cursor();
            }
        }

        public override void import_css(out string text, string url, ref string baseurl)
        {
            baseurl = string.Empty;
            make_url(url, baseurl, out var css_url);
            load_text_file(css_url, out text, out var newurl);
            if (!string.IsNullOrEmpty(text))
                baseurl = css_url;
        }

        public override void set_caption(string caption) { if (Parent != null) Parent.Text = caption; }

        public override void set_base_url(string base_url) => _base_url = !string.IsNullOrEmpty(base_url) ? urljoin(_url, base_url) : _url;

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            using (var file = _http.GetStream(url))
                try { return file != null ? Image.FromStream(file) : null; }
                catch { return null; }
        }

        public void open_page(string url)
        {
            _url = url;
            _base_url = url;
            load_text_file(url, out var html, out var newurl);
            _url = newurl;
            _base_url = newurl;
            ((BrowserForm)Parent).set_url(_url);
            _html = document.createFromString(html, this, null, _context);
            if (_html != null)
            {
                _rendered_width = Width;
                _html.render(_rendered_width);
                //set_size_request(_html.width, _html.height);
            }
            Refresh();
        }

        protected override void make_url(string url, string basepath, out string urlout) => urlout = string.IsNullOrEmpty(basepath) ? !string.IsNullOrEmpty(_base_url) ? urljoin(_base_url, url) : url : urljoin(basepath, url);

        protected override void OnResize(EventArgs e)
        {
            if (_html != null && _rendered_width != Width)
            {
                _rendered_width = Width;
                _html.media_changed();
                _html.render(_rendered_width);
                //set_size_request(_html.width, _html.height);
                Refresh();
            }
        }

        //bool html_widget::on_button_press_event(GdkEventButton*event)

        //bool html_widget::on_button_release_event(GdkEventButton*event)

        //bool html_widget::on_motion_notify_event(GdkEventMotion*event)

        void update_cursor() => Cursor = _cursor == "pointer" ? Cursors.Hand : Cursors.Default;

        void load_text_file(string url, out string out_, out string newurl)
        {
            if (url.IndexOf("://") == -1)
                url = "https://" + url;
            var stream = _http.Get(url);
            newurl = stream.RequestMessage.RequestUri.ToString();
            using (var r = new StreamReader(stream.Content.ReadAsStreamAsync().Result))
                out_ = r.ReadToEnd();
        }
    }
}
