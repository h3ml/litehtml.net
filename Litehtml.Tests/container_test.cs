using System;
using System.Collections.Generic;

namespace Litehtml
{
    public class container_test : Icontainer
    {
        public void Dispose() { }
        public object create_font(string faceName, int size, int weight, font_style italic, uint decoration, out font_metrics fm) { fm = default(font_metrics); return IntPtr.Zero; }
        public void delete_font(object hFont) { }
        public int text_width(string text, object hFont) => 0;
        public void draw_text(object hdc, string text, object hFont, web_color color, position pos) { }
        public int pt_to_px(int pt) => 0;
        public int get_default_font_size() => 12;
        public string get_default_font_name() => "Arial";
        public void draw_list_marker(object hdc, list_marker marker) { }
        public void load_image(string src, string baseurl, Dictionary<string, string> attrs, bool redraw_on_ready) { }
        public void get_image_size(string src, string baseurl, Dictionary<string, string> attrs, out size sz) { sz = default(size); }
        public void draw_background(object hdc, background_paint bg) { }
        public void draw_borders(object hdc, borders borders, position draw_pos, bool root) { }
        public void set_caption(string caption) { }
        public void set_base_url(string base_url) { }
        public void link(document doc, element el) { }
        public void on_anchor_click(string url, element el) { }
        public void set_cursor(string cursor) { }
        public void transform_text(string text, text_transform tt) { }
        public void import_css(out string text, string url, ref string baseurl) { text = null; }
        public void set_clip(position pos, border_radiuses bdr_radius, bool valid_x, bool valid_y) { }
        public void del_clip() { }
        public void get_client_rect(out position client) { client = default(position); }
        public element create_element(string tag_name, Dictionary<string, string> attributes, document doc) => null;
        public void get_media_features(media_features media) { }
        public void get_language(out string language, out string culture) { language = "en"; culture = string.Empty; }
        public string resolve_color(string color) => null;
    }
}