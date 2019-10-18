using Litehtml;
using System;
using System.Windows.Forms;

namespace Browser.Windows
{
    public partial class BrowserForm : Form
    {
        readonly int _widthAdjust;
        readonly int _heightAdjust;

        public BrowserForm(context ctx)
        {
            InitializeComponent();
            _widthAdjust = Width - _html.Width;
            _heightAdjust = Height - _html.Height;
            SetSize(840, 640);
            _html.Set(ctx);
        }

        public void open(string url) => _html.open_page(url);

        void SetSize(int width, int height)
        {
            Width = width; Height = height;
            BrowserForm_Resize(null, null);
        }

        void on_go_clicked(object sender, EventArgs e) => _html.open_page(_address_bar.Text);

        void on_address_key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                _address_bar.Select(0, -1);
                on_go_clicked(null, null);
                e.Handled = true;
            }
        }

        public void open_url(string url)
        {
            _address_bar.Text = url;
            _html.open_page(url);
        }

        public void set_url(string url) => _address_bar.Text = url;

        void BrowserForm_Resize(object sender, EventArgs e)
        {
            _html.Width = Width - _widthAdjust;
            _html.Height = Height - _heightAdjust;
        }
    }
}
