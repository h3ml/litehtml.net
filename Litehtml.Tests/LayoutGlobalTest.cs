using NUnit.Framework;

namespace Litehtml
{
    public class LayoutGlobalTest
    {
        [Test]
        public void Test()
        {
            var doc = document.createFromString("<html>Body</html>", new container_test(), null, new context());
            doc.render(500, render_type.all);
        }
    }
}
