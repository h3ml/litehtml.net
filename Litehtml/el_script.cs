using System.Diagnostics;

namespace Litehtml
{
    [DebuggerDisplay("<script />")]
    public class el_script : element
    {
        string _text;

        public el_script(document doc) : base(doc) { }

        public override void parse_attributes()
        {
            var doc = get_document();
            doc.script?.addScript(doc, _text);
        }

        public override bool appendChild(element el) { el.get_text(ref _text); return true; }

        public override string get_tagName() => "script";
    }
}
