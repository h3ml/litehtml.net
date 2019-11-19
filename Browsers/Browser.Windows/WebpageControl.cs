using Litehtml;
using Litehtml.Containers;
using Litehtml.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Browser.Windows
{
    public partial class WebpageControl : container_form
    {
        internal const string USERAGENT = "litebrowser/1.0";
        internal const string USERAGENT2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
        internal readonly HttpService _http = new HttpService(USERAGENT);
        internal string _url;
        string _base_url;
        internal document _doc;
        internal string _caption;
        internal string _cursor;
        internal string _hash;

        public WebpageControl()
        {
            InitializeComponent();
        }

        public override void set_caption(string caption) => _caption = caption;

        public override void set_base_url(string base_url)
        {
            if (base_url != null)
            {
                if (!Path.IsPathRooted(base_url) && !Uri.IsWellFormedUriString(base_url, UriKind.RelativeOrAbsolute))
                    make_url(base_url, _url, out _base_url);
                else
                    _base_url = base_url;
            }
            else
                _base_url = _url;
        }

        protected override void make_url(string url, string basepath, out string urlout)
        {
            urlout = string.IsNullOrEmpty(basepath) ? !string.IsNullOrEmpty(_base_url) ? urljoin(_base_url, url) : url : urljoin(basepath, url);
        }

        public override void import_css(out string text, string url, ref string baseurl)
        {
            text = null;
            make_url(url, baseurl, out var css_url);
            if (download_and_wait(css_url, out var file))
            {
                var css = load_utf8_file(file, false, "UTF-8");
                if (css != null)
                {
                    baseurl = css_url;
                    text = css;
                }
            }
        }

        public override void on_anchor_click(string url, element el)
        {
            make_url(url, null, out var anchor);
            ((HtmlControl)Parent).open(anchor);
        }

        public override void set_cursor(string cursor) => _cursor = cursor;

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                _http.GetPromise(url,
                    t => on_image_loaded(t.Content.ReadAsStreamAsync().Result, url, redraw_on_ready),
                    t => on_document_error(t));
                return null;
            }
            else
                using (var file = _http.GetStream(url))
                    try { return file != null ? Image.FromStream(file) : null; }
                    catch { return null; }
        }

        public void load(string url)
        {
            _url = url;
            _base_url = url;
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                _http.GetPromise(url,
                    t => on_document_loaded(t.Content.ReadAsStreamAsync().Result, "UTF-8", t.RequestMessage.RequestUri.ToString()),
                    t => on_document_error(t));
                return;
            }
            else
                using (var file = _http.GetStream(url))
                    on_document_loaded(file, "UTF-8", null);
        }

        void on_document_loaded(Stream file, string encoding, string realUrl)
        {
            if (realUrl != null)
                _url = realUrl;
            var html_text = load_utf8_file(file, true);
            if (html_text == null)
                html_text = "<h1>Something Wrong</h1>";
            _doc = document.createFromUTF8(html_text, this, new DefaultScriptEngine((HtmlControl)Parent), ((HtmlControl)Parent).get_html_context());
            ((HtmlControl)Parent).OnPageReady();
        }

        string load_text_file(string url, bool is_html, string defEncoding = "UTF-8")
        {
            using (var file = _http.GetStream(url))
            {
                var utf8 = load_utf8_file(file, is_html, defEncoding);
                return utf8 != null ? utf8 : null;
            }
        }

        void on_document_error(string errMsg)
        {
            var txt = "<h1>Something Wrong</h1>";
            if (errMsg != null)
            {
                txt += "<p>";
                txt += errMsg;
                txt += "</p>";
            }
            _doc = document.createFromString(txt, this, null, ((HtmlControl)Parent).get_html_context());
            ((HtmlControl)Parent).OnPageReady();
        }

        void on_image_loaded(Stream file, string url, bool redraw_only)
        {
            try
            {
                var img = Image.FromStream(file);
                add_image(url, img);
                if (_doc != null)
                    ((HtmlControl)Parent).OnImageReady(redraw_only);
            }
            catch { }
        }

        bool download_and_wait(string url, out Stream file)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                Stream file2 = null;
                _http.GetPromise(url,
                    t => file2 = t.Content.ReadAsStreamAsync().Result,
                    t => file2 = null);
                file = file2;
                return file2 != null;
            }
            else
            {
                file = _http.GetStream(url);
                return true;
            }
        }

        public override void get_client_rect(out position client) => ((HtmlControl)Parent).get_client_rect(out client);

        public void get_url(out string url)
        {
            url = _url;
            if (!string.IsNullOrEmpty(_hash))
            {
                url += "#";
                url += _hash;
            }
        }

        string load_utf8_file(Stream file, bool is_html, string defEncoding = "UTF-8")
        {
            using (var r = new StreamReader(file))
                return r.ReadToEnd();
        }
    }
}
