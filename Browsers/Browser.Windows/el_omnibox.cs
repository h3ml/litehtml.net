using Litehtml;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Browser.Windows
{
    public class el_omnibox : html_tag
    {
        readonly TextBox _edit = new TextBox();
        Control Parent;
        bool _haveFocus = false;

        public el_omnibox(document doc, Control parent, Icontainer container) : base(doc)
        {
            Parent = parent;
            Parent.Controls.Add(_edit);
            _edit.KeyPress += _edit_KeyPress;
        }

        void _edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                var url = get_url();
                _edit.SelectAll();
                ((BrowserForm)((ToolbarControl)Parent).ParentForm).open(url);
            }
        }

        bool have_focus => _haveFocus;

        public void update_position()
        {
            var pos = get_placement();
            _edit.SetBounds(pos.x, pos.y, pos.width, pos.height);
        }

        public void set_url(string url) => _edit.Text = url;

        public override void draw(object hdc, int x, int y, int z, position clip)
        {
            base.draw(hdc, x, y, z, clip);
            _edit.Update();
        }

        public override void parse_styles(bool is_reparse)
        {
            base.parse_styles(is_reparse);
            _edit.Font = (Font)get_font();
            var color = get_color("color", true);
            _edit.ForeColor = Color.FromArgb(color.alpha, color.red, color.green, color.blue);
        }

        //void set_parent(Control parent)
        //{
        //    Parent = parent;
        //    _edit.set_parent(parent);
        //}

        public override void on_click()
        {
            if (!_haveFocus)
            {
                //SendMessage(m_hWndParent, WM_OMNIBOX_CLICKED, 0, 0);
            }
        }

        public void SetFocus()
        {
            //_edit.showCaret();
            //_edit.setSelection(0, -1);
            //_haveFocus = true;
        }

        void KillFocus()
        {
            //_edit.setSelection(0, 0);
            //_edit.hideCaret();
            //_haveFocus = false;
        }

        string get_url()
        {
            var str = _edit.Text;
            if (!Uri.IsWellFormedUriString(str, UriKind.RelativeOrAbsolute))
            {
                //DWORD sz = (DWORD)str.length() + 32;
                //LPWSTR outUrl = new WCHAR[sz];
                //HRESULT res = UrlApplyScheme(str.c_str(), outUrl, &sz, URL_APPLY_DEFAULT);
                //if (res == E_POINTER)
                //{
                //    delete outUrl;
                //    LPWSTR outUrl = new WCHAR[sz];
                //    if (UrlApplyScheme(str.c_str(), outUrl, &sz, URL_APPLY_DEFAULT) == S_OK)
                //    {
                //        str = outUrl;
                //    }
                //}
                //else if (res == S_OK)
                //{
                //    str = outUrl;
                //}
                //delete outUrl;
            }
            return str;
        }

        bool OnLButtonDown(int x, int y, int z = 0)
        {
            if (_haveFocus)
            {
                var pos = get_placement();
                if (_edit.Capture || pos.is_point_inside(x, y, z))
                {
                    //_edit.OnLButtonDown(x, y);
                    return true;
                }
            }
            return false;
        }

        bool OnLButtonUp(int x, int y, int z = 0)
        {
            if (_haveFocus)
            {
                var pos = get_placement();
                if (_edit.Capture || pos.is_point_inside(x, y, z))
                {
                    //_edit.OnLButtonUp(x, y);
                    return true;
                }
            }
            return false;
        }

        bool OnLButtonDblClick(int x, int y, int z = 0)
        {
            if (_haveFocus)
            {
                var pos = get_placement();
                if (pos.is_point_inside(x, y, z))
                {
                    //_edit.OnLButtonDblClick(x, y, z);
                    return true;
                }
            }
            return false;
        }

        public bool OnMouseMove(int x, int y, int z = 0)
        {
            if (_haveFocus)
            {
                var pos = get_placement();
                if (_edit.Capture || pos.is_point_inside(x, y, z))
                {
                    //_edit.OnMouseMove(x, y);
                    return true;
                }
            }
            return false;
        }
    }
}
