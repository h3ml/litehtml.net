using Litehtml;
using Litehtml.Containers;
using Litehtml.Services;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Browser.Unity
{
    public class HtmlControl : container_unity
    {
        internal const string USERAGENT = "litebrowser/1.0";
        internal const string USERAGENT2 = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
        readonly HttpService _http = new HttpService(USERAGENT);
        string _url;
        string _base_url;
        document _doc;
        readonly context _context = new context();
        int _rendered_width;
        string _cursor;
        string _clicked_url;
        Vector3 _size;

        protected virtual void Start()
        {
            _size = new Vector3(500, 500, 10);
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

        public override void get_client_rect(out position client) => client = new position
        {
            width = (int)_size.x,
            height = (int)_size.y,
            depth = (int)_size.z,
            x = 0,
            y = 0,
            z = 0,
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

        public override void set_caption(string caption) { }

        public override void set_base_url(string base_url) => _base_url = !string.IsNullOrEmpty(base_url) ? urljoin(_url, base_url) : _url;

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            using (var file = _http.GetStream(url))
                try
                {
                    if (file.Length <= 0)
                        return null;
                    var m = new MemoryStream();
                    file.CopyTo(m);
                    var tex = new Texture2D(1, 1);
                    var loaded = tex.LoadImage(m.ToArray());
                    if (!loaded)
                        Debug.Log("get_image: !loaded");
                    return tex;
                }
                catch { Debug.Log("get_image Exception"); return null; }
        }

        public void open_page(string url)
        {
            _url = url;
            _base_url = url;
            load_text_file(url, out var html, out var newurl);
            _url = newurl;
            _base_url = newurl;
            //_browser.set_url(_url);
            _doc = document.createFromString(html, this, null, _context);
            if (_doc != null)
            {
                _rendered_width = (int)_size.x;
                _doc.render(_rendered_width);
            }
            Refresh();
        }

        protected override void make_url(string url, string basepath, out string urlout) => urlout = string.IsNullOrEmpty(basepath) ? !string.IsNullOrEmpty(_base_url) ? urljoin(_base_url, url) : url : urljoin(basepath, url);

        protected void OnResize()
        {
            if (_doc != null && _rendered_width != (int)_size.x)
            {
                _rendered_width = (int)_size.x;
                _doc.media_changed();
                _doc.render(_rendered_width);
                Refresh();
            }
        }

        void update_cursor() { }

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
