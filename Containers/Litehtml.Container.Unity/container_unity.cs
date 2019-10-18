using System;
using System.Collections.Generic;
using UnityEngine;

namespace Litehtml.Containers
{
    public class container_unity : MonoBehaviour, Icontainer
    {
        readonly Dictionary<string, object> _assets = new Dictionary<string, object>();
        readonly Dictionary<string, object> _images = new Dictionary<string, object>();
        readonly List<position> _clips = new List<position>();

        public virtual void get_client_rect(out position client) => throw new NotImplementedException();
        public virtual void import_css(out string text, string url, ref string baseurl) => throw new NotImplementedException();
        public virtual void on_anchor_click(string url, element el) => throw new NotImplementedException();
        public string resolve_color(string color) => null;
        public virtual void set_base_url(string base_url) => throw new NotImplementedException();
        public virtual void set_caption(string caption) => throw new NotImplementedException();
        public virtual void set_cursor(string cursor) => throw new NotImplementedException();
        protected virtual object get_image(string url, Dictionary<string, string> attrs, bool redraw_on_ready) => throw new NotImplementedException();

        public void Refresh() => OnPaint();

        protected virtual void OnPaint() { }

        class UnityFont : IDisposable
        {
            public Font Font;
            public System.Drawing.Font SystemFont;

            public void Dispose() => SystemFont.Dispose();

            public static UnityFont Create(string faceName, int size, int weight, font_style italic, uint decoration, out font_metrics fm)
            {
                // Unity
                var fnt = Font.CreateDynamicFontFromOSFont(faceName, size);
                //fm.ascent = fnt.ascent;
                //fm.descent = 0;
                //fm.x_height = fm.height = fnt.lineHeight;
                //fm.draw_spaces = italic == font_style.italic || decoration != 0;
                // From System
                var fontStyle = italic == font_style.italic ? System.Drawing.FontStyle.Italic : System.Drawing.FontStyle.Regular;
                if ((decoration & types.font_decoration_linethrough) != 0)
                    fontStyle |= System.Drawing.FontStyle.Strikeout;
                if ((decoration & types.font_decoration_underline) != 0)
                    fontStyle |= System.Drawing.FontStyle.Underline;
                var fnt2 = new System.Drawing.Font(faceName, size, fontStyle);
                var fntFamily = fnt2.FontFamily;
                var dpi = 96;
                fm.ascent = fntFamily.GetCellAscent(fontStyle) / dpi;
                fm.descent = fntFamily.GetCellDescent(fontStyle) / dpi;
                fm.x_height = fm.height = fntFamily.GetEmHeight(fontStyle) / dpi;
                fm.draw_spaces = italic == font_style.italic || decoration != 0;
                return new UnityFont { Font = fnt, SystemFont = fnt2 };
            }

            //public int MeasureText(string text)
            //{
            //    if (string.IsNullOrEmpty(text))
            //        return 0;
            //    var font = Font;
            //    var width = 0;
            //    if (font.dynamic)
            //        font.RequestCharactersInTexture(text, font.fontSize);
            //    foreach (var c in text.ToCharArray())
            //    {
            //        if (!font.GetCharacterInfo(c, out var characterInfo, font.fontSize))
            //            Debug.Log("error!");
            //        width += characterInfo.advance;
            //    }
            //    return width;
            //}

            public int MeasureText(string text) => System.Windows.Forms.TextRenderer.MeasureText(text, SystemFont).Width;
        }

        static Vector3 ToUnityVector(Vector3 vector) { Swap(ref vector.y, ref vector.z); return vector; }

        static void Swap<T>(ref T a, ref T b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }

        void hdc_DrawImage(GameObject hdc, Texture tex, int x, int y, int z)
        {
            var obj = GameObject.CreatePrimitive(PrimitiveType.Quad);
            obj.transform.SetParent(hdc.transform);
            obj.transform.localPosition = ToUnityVector(new Vector3(x, y, z));
            obj.transform.localScale = new Vector3(tex.width, tex.height, 0);
            var mat = obj.GetComponent<MeshRenderer>().material;
            mat.shader = Shader.Find("UI/Default");
            mat.mainTexture = tex;
            //var ratio = tex.height / (float)tex.width;
            //var x2 = 5.0F;
            //var y2 = x2 * ratio;
            //var z2 = 1;
            //obj.transform.localScale = new Vector3(x2, y2, z2);
        }

        void hdc_DrawObject(GameObject hdc, GameObject obj, int x, int y, int z)
        {
            obj.transform.SetParent(hdc.transform);
            obj.transform.localPosition = ToUnityVector(new Vector3(x, y, z));
            //obj.transform.localScale = new Vector3(obj.width, obj.height, 0);
        }

        public object create_font(string faceName, int size, int weight, font_style italic, uint decoration, out font_metrics fm) => UnityFont.Create(faceName, size, weight, italic, decoration, out fm);

        public void delete_font(object hFont) => ((UnityFont)hFont).Dispose();

        public int text_width(string text, object hFont) => ((UnityFont)hFont).MeasureText(text);

        public void draw_text(object hdc, string text, object hFont, web_color color, position pos)
        {
            var root = (GameObject)hdc;
            var font = ((UnityFont)hFont).Font;
            var obj = new GameObject("Text");
            obj.transform.SetParent(root.transform);
            obj.transform.localPosition = ToUnityVector(new Vector3(pos.left, pos.top, pos.depth));
            //obj.transform.localScale = new Vector3(1, 1, 0);
            var textMesh = obj.AddComponent<TextMesh>();
            textMesh.font = font;
            textMesh.text = text;
            textMesh.color = new Color(color.red, color.green, color.blue);
            var mat = obj.GetComponent<MeshRenderer>().material;
            mat.mainTexture = font.material.mainTexture;
            mat.shader = Shader.Find("GUI/3D Text Shader");
        }

        public int pt_to_px(int pt) => pt * 96 / 72;

        public int get_default_font_size() => 16;

        public void draw_list_marker(object hdc, list_marker marker)
        {
            var root = (GameObject)hdc;
            if (!string.IsNullOrEmpty(marker.image))
            {
                make_url(marker.image, marker.baseurl, out var url);
                if (_images.TryGetValue(url, out var img) && img is Texture tex)
                    draw_bmp(root, tex, marker.pos);
            }
            else
                switch (marker.marker_type)
                {
                    case list_style_type.circle:
                        {
                            draw_ellipse(root, marker.pos.x, marker.pos.y, marker.pos.width, marker.pos.height, marker.color, 1);
                        }
                        break;
                    case list_style_type.disc:
                        {
                            fill_ellipse(root, marker.pos.x, marker.pos.y, marker.pos.width, marker.pos.height, marker.color);
                        }
                        break;
                    case list_style_type.square:
                        {
                            fill_rect(root, marker.pos.x, marker.pos.y, marker.pos.width, marker.pos.height, marker.color, new css_border_radius());
                        }
                        break;
                }
        }

        public void add_image(string url, object img) => _images[url] = img;
        public void load_image(string src, string baseurl, Dictionary<string, string> attrs, bool redraw_on_ready)
        {
            make_url(src, baseurl, out var url);
            if (!_images.ContainsKey(url))
            {
                var img = get_image(url, attrs, redraw_on_ready);
                if (img != null)
                    _images[url] = img;
            }
        }

        public void get_image_size(string src, string baseurl, Dictionary<string, string> attrs, out size sz)
        {
            sz = new size();
            make_url(src, baseurl, out var url);
            if (_images.TryGetValue(url, out var img) && img is Texture tex)
            {
                sz.width = tex.width;
                sz.height = tex.height;
            }
        }

        public void draw_image(object hdc, string src, string baseurl, Dictionary<string, string> attrs, position pos)
        {
            var root = (GameObject)hdc;
            make_url(src, baseurl, out var url);
            if (_images.TryGetValue(url, out var img) && img is Texture tex)
                draw_bmp(root, tex, pos);
        }

        void draw_bmp(GameObject hdc, Texture tex, position pos) => hdc_DrawImage(hdc, tex, pos.left, pos.top, pos.depth);

        public void draw_background(object hdc, background_paint bg)
        {
            var root = (GameObject)hdc;
            make_url(bg.image, bg.baseurl, out var url);
            if (_images.TryGetValue(url, out var img) && img is Texture tex)
                draw_img_bg(root, tex, bg);
        }

        protected void draw_img_bg(GameObject hdc, Texture tex, background_paint bg)
        {
            var tex_width = tex.width;
            var tex_height = tex.height;
            switch (bg.repeat)
            {
                case background_repeat.no_repeat:
                    {
                        hdc_DrawImage(hdc, tex, bg.position_x, bg.position_y, bg.position_z);
                    }
                    break;
                case background_repeat.repeat_x:
                    {
                        //        var bmp = new CachedBitmap(bgbmp, hdc);
                        //        for (var x = pos.left; x < pos.right; x += bgbmp_Width)
                        //            hdc.DrawCachedBitmap(bmp, x, pos.top);
                        //        for (var x = pos.left - bgbmp_Width; x + bgbmp_Width > draw_pos.left; x -= bgbmp_Width)
                        //            hdc.DrawCachedBitmap(&bmp, x, pos.top);
                    }
                    break;
                case background_repeat.repeat_y:
                    {
                        //        var bmp = new CachedBitmap(bgbmp, hdc);
                        //        for (var y = pos.top; y < pos.bottom; y += bgbmp_Height)
                        //            hdc.DrawCachedBitmap(bmp, pos.left, y);
                        //        for (var y = pos.top - bgbmp_Height; y + bgbmp_Height > draw_pos.top; y -= bgbmp_Height)
                        //            hdc.DrawCachedBitmap(&bmp, pos.left, y);
                    }
                    break;
                case background_repeat.repeat:
                    {
                        //        var bmp = new CachedBitmap(bgbmp, hdc);
                        //        if (bgbmp_Height >= 0)
                        //            for (var x = pos.left; x < pos.right; x += bgbmp_Width)
                        //                for (var y = pos.top; y < pos.bottom; y += bgbmp_Height)
                        //                    hdc.DrawCachedBitmap(&bmp, x, y);
                    }
                    break;
            }
        }

        protected virtual void make_url(string url, string basepath, out string urlout) => urlout = url;

        public void draw_borders(object hdc, borders borders, position draw_pos, bool root = false)
        {
        }

        public void transform_text(string text, text_transform tt) { }

        public void set_clip(position pos, border_radiuses bdr_radius, bool valid_x, bool valid_y)
        {
            var clip_pos = pos;
            get_client_rect(out var client_pos);
            if (!valid_x)
            {
                clip_pos.x = client_pos.x;
                clip_pos.width = client_pos.width;
            }
            if (!valid_y)
            {
                clip_pos.y = client_pos.y;
                clip_pos.height = client_pos.height;
            }
            _clips.Add(clip_pos);
        }

        public void del_clip()
        {
            if (_clips.Count != 0)
                _clips.RemoveAt(_clips.Count - 1);
        }

        protected void fill_rect(GameObject hdc, int x, int y, int width, int height, web_color color, css_border_radius radius)
        {
        }

        protected void draw_ellipse(GameObject hdc, int x, int y, int width, int height, web_color color, int line_width)
        {
        }

        protected void fill_ellipse(GameObject hdc, int x, int y, int width, int height, web_color color)
        {
        }

        protected void clear_images()
        {
            _images.Clear();
        }

        public string get_default_font_name() => "sans-serif";

        public virtual element create_element(string tag_name, Dictionary<string, string> attributes, document doc) => null;

        public void get_media_features(media_features media)
        {
            get_client_rect(out var client);
            media.type = media_type.screen;
            media.width = client.width;
            media.height = client.height;
            // var screen = Screen.FromControl(this);
            // var screenBounds = screen.Bounds;
            // media.device_width = screenBounds.Width;
            // media.device_height = screenBounds.Height;
            media.color = 8;
            media.monochrome = 0;
            media.color_index = 256;
            media.resolution = 96;
        }

        public void get_language(out string language, out string culture) { language = "en"; culture = string.Empty; }

        public void link(document doc, element el) { }

        protected static string urljoin(string base_, string relative)
        {
            try { return new Uri(new Uri(base_), relative).ToString(); }
            catch { return relative; }
        }
    }
}
