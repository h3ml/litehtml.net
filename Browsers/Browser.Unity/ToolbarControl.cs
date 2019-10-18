using Litehtml;
using Litehtml.Containers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Browser.Unity
{
    public class ToolbarControl : container_unity
    {
        readonly context _context = new context();
        document _doc;
        el_omnibox _omnibox;
        string _cursor;
        bool _inCapture;
        Vector3 _size;

        protected virtual void Start()
        {
            _size = new Vector3(500, 500, 10);
        }

        void render_toolbar(int width)
        {
            if (_doc == null)
                return;
            _doc.render(width);
            _omnibox?.update_position();
        }

        void update_cursor()
        {
            //var defArrow = Cursors.Arrow; //Cursors.Default
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
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Browser.Unity.toolbar.toolbar.html"))
            using (var reader = new StreamReader(stream))
                html = reader.ReadToEnd();
            _doc = document.createFromString(html, this, null, _context);
            render_toolbar((int)_size.x);
            //MoveWindow(x, y, Width, _doc.height, true);
        }

        protected override object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Browser.Unity.toolbar.{url}"))
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

        public void on_page_loaded(string url)
        {
            _omnibox?.set_url(url);
        }

        void OnMouseMove(int x, int y, int z)
        {
            if (_doc == null)
            {
                update_cursor();
                return;
            }
            _omnibox?.OnMouseMove(x, y);
            if (!_inCapture)
            {
                var redraw_boxes = new List<position>();
                if (_doc.on_mouse_over(x, y, z, x, y, z, redraw_boxes))
                {
                    //foreach (var box in redraw_boxes)
                    //    Invalidate(new Rectangle
                    //    {
                    //        X = box.x,
                    //        Y = box.y,
                    //        Width = box.width,
                    //        Height = box.height,
                    //    }, true);
                    //Update();
                }
            }
            update_cursor();
        }

        void OnMouseLeave()
        {
            if (_doc == null)
                return;
            var redraw_boxes = new List<position>();
            if (_doc.on_mouse_leave(redraw_boxes))
            {
                //foreach (var box in redraw_boxes)
                //    Invalidate(new Rectangle
                //    {
                //        X = box.x,
                //        Y = box.y,
                //        Width = box.width,
                //        Height = box.height,
                //    }, true);
                //Update();
            }
        }

        void OnOmniboxClicked()
        {
            //Focus();
            _omnibox?.SetFocus();
        }

        void OnLButtonDown(int x, int y, int z = 0)
        {
            if (_doc == null)
                return;
            var process = true;
            //if (_omnibox?.OnLButtonDown(x, y))
            //    process = false;
            if (process && !_inCapture)
            {
                var redraw_boxes = new List<position>();
                if (_doc.on_lbutton_down(x, y, z, x, y, z, redraw_boxes))
                {
                    //foreach (var box in redraw_boxes)
                    //    Invalidate(new Rectangle
                    //    {
                    //        X = box.x,
                    //        Y = box.y,
                    //        Width = box.width,
                    //        Height = box.height,
                    //    }, true);
                    //Update();
                }
            }
        }

        void OnLButtonUp(int x, int y, int z = 0)
        {
            if (_doc == null)
                return;
            var process = true;
            //if (_omnibox?.OnLButtonUp(x, y))
            //    process = false;
            if (process && !_inCapture)
            {
                var redraw_boxes = new List<position>();
                if (_doc.on_lbutton_up(x, y, z, x, y, z, redraw_boxes))
                {
                    //foreach (var box in redraw_boxes)
                    //    Invalidate(new Rectangle
                    //    {
                    //        X = box.x,
                    //        Y = box.y,
                    //        Width = box.width,
                    //        Height = box.height,
                    //    }, true);
                    //Update();
                }
            }
        }

        (string, string)[] g_bookmarks = new (string, string)[]
        {
            ("DMOZ",                    "http://www.dmoz.org/"),
            ("litehtml project",        "https://github.com/litehtml/litehtml"),
            ("litehtml website",        "http://www.litehtml.com/"),
            ("True Launch Bar",         "http://www.truelaunchbar.com/"),
            ("Tordex",                  "http://www.tordex.com/"),
            ("True Paste",              "http://www.truepaste.com/"),
            ("Text Accelerator",        "http://www.textaccelerator.com/"),
            ("Wiki: Web Browser",       "http://en.wikipedia.org/wiki/Web_browser"),
            ("Wiki: Obama",             "http://en.wikipedia.org/wiki/Obama"),
            ("Code Project",            "http://www.codeproject.com/"),
            (null, null),
        };

        public override void on_anchor_click(string url, element el)
        {
            //var parent = (BrowserForm)Parent;
            //if (url == "back") parent.back();
            //else if (url == "forward") parent.forward();
            //else if (url == "reload") parent.reload();
            //else if (url == "bookmarks")
            //{
            //    var pos = el.get_placement();
            //    //POINT pt;
            //    //pt.x = pos.right;
            //    //pt.y = pos.bottom;
            //    //MapWindowPoints(_hWnd, NULL, &pt, 1);
            //    //HMENU hMenu = CreatePopupMenu();
            //    //for (int i = 0; g_bookmarks[i].url; i++)
            //    //    InsertMenu(hMenu, -1, MF_BYPOSITION | MF_STRING, i + 1, g_bookmarks[i].Item1);
            //    //int ret = TrackPopupMenu(hMenu, TPM_RIGHTALIGN | TPM_TOPALIGN | TPM_NONOTIFY | TPM_RETURNCMD, pt.x, pt.y, 0, m_hWnd, NULL);
            //    //DestroyMenu(hMenu);
            //    var ret = 0;
            //    if (ret != 0)
            //        parent.open(g_bookmarks[ret - 1].Item2);
            //}
            //else if (url == "settings")
            //{
            //    var pos = el.get_placement();
            //    //POINT pt;
            //    //pt.x = pos.right;
            //    //pt.y = pos.bottom;
            //    //MapWindowPoints(_hWnd, NULL, &pt, 1);
            //    //HMENU hMenu = CreatePopupMenu();
            //    //InsertMenu(hMenu, -1, MF_BYPOSITION | MF_STRING, 1, L"Calculate Render Time");
            //    //InsertMenu(hMenu, -1, MF_BYPOSITION | MF_STRING, 3, L"Calculate Render Time (10)");
            //    //InsertMenu(hMenu, -1, MF_BYPOSITION | MF_STRING, 4, L"Calculate Render Time (100)");
            //    //InsertMenu(hMenu, -1, MF_BYPOSITION | MF_SEPARATOR, 0, L"");
            //    //InsertMenu(hMenu, -1, MF_BYPOSITION | MF_STRING, 2, L"Exit");
            //    //int ret = TrackPopupMenu(hMenu, TPM_RIGHTALIGN | TPM_TOPALIGN | TPM_NONOTIFY | TPM_RETURNCMD, pt.x, pt.y, 0, m_hWnd, NULL);
            //    //DestroyMenu(hMenu);
            //    var ret = 0;
            //    switch (ret)
            //    {
            //        case 2: Application.Quit(); break;
            //        case 1: parent.calc_time(); break;
            //        case 3: parent.calc_time(10); break;
            //        case 4: parent.calc_time(100); break;
            //    }
            //}
        }

        public override void set_cursor(string cursor) => _cursor = cursor;

        public override element create_element(string tag_name, Dictionary<string, string> attributes, document doc)
        {
            if (string.Equals(tag_name, "input", StringComparison.OrdinalIgnoreCase))
                if (attributes.TryGetValue("type", out var type))
                    if (string.Equals(type, "text", StringComparison.OrdinalIgnoreCase))
                    {
                        _omnibox = new el_omnibox(doc, this.gameObject, this);
                        return _omnibox;
                    }
            return null;
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
    }
}
