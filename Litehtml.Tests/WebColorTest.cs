using NUnit.Framework;

namespace Litehtml
{
    public class WebColorTest
    {
        [Test]
        public void WebColorParseTest()
        {
            var container = new container_test();
            web_color c;
            c = web_color.from_string("", container); Assert.AreEqual(c.red, 0); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 0);
            c = web_color.from_string("#f0f", container); Assert.AreEqual(c.red, 255); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 255);
            c = web_color.from_string("#ff00ff", container); Assert.AreEqual(c.red, 255); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 255);
            c = web_color.from_string("rgb()", container); Assert.AreEqual(c.red, 0); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 0);
            c = web_color.from_string("rgb(255,0,255)", container); Assert.AreEqual(c.red, 255); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 255);
            c = web_color.from_string("red", container); Assert.AreEqual(c.red, 255); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 0);
            c = web_color.from_string("unknown", container); Assert.AreEqual(c.red, 0); Assert.AreEqual(c.green, 0); Assert.AreEqual(c.blue, 0);
        }
    }
}
