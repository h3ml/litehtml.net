using System.IO;
using System.Reflection;

namespace Litehtml.Services
{
    public class Resources
    {
        public static readonly string master_css;

        static Resources()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Litehtml.Services.master.css"))
            using (var reader = new StreamReader(stream))
                master_css = reader.ReadToEnd();
        }
    }
}