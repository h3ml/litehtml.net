using NUnit.Framework;

namespace Litehtml
{
    public class nodeTest
    {
        Document MakeDoc(string source) => document.createFromString(source.Replace("'", "\""), new container_test(), null, new context());

        [Test]
        public void AttribTest()
        {
            var document = MakeDoc(@"
<html>
<body>
    <button onclick='myFunction()'>Try it</button>
    <p id='demo'></p>
    <div class='w3-code notranslate'>
        <img src='pic_bulboff.gif' width='100' height='180'>
    </div>
</body>
</html>");

            // https://www.w3schools.com/jsref/prop_attr_name.asp
            {
                var x = document.getElementsByTagName("BUTTON")[0].attributes[0].name;
            }

            // https://www.w3schools.com/jsref/prop_attr_value.asp
            {
                var x = document.getElementsByTagName("BUTTON")[0].attributes[0].value;
            }
            {
                var x = document.getElementsByTagName("IMG")[0] as Element;
                x.getAttributeNode("src").value = "pic_bulbon.gif";
            }

            // https://www.w3schools.com/jsref/prop_attr_specified.asp
            {
                var x = document.getElementById("demo").attributes[0].specified;
            }
        }

        [Test]
        public void NodemapTest()
        {
            var document = MakeDoc(@"
<html>
<body>
    <img id='myImg' alt='Flower' src='klematis.jpg' width='150' height='113'>
    <button onclick='myFunction()'>Try it</button>
    <p id='demo'></p>
</body>
</html>");

            // https://www.w3schools.com/jsref/met_namednodemap_getnameditem.asp
            {
                var btn = document.getElementsByTagName("BUTTON")[0] as Element;
                var a = btn.attributes.getNamedItem("onclick").value;
            }

            // https://www.w3schools.com/jsref/met_namednodemap_item.asp
            {
                var x = document.getElementsByTagName("BUTTON")[0].attributes.item(0).nodeName;
            }
            {
                var a = document.getElementsByTagName("BUTTON")[0].attributes.item(1);   // The 2nd attribute
            }
            {
                var a = document.getElementsByTagName("BUTTON")[0].attributes[1];        // The 2nd attribute
            }
            {
                document.getElementsByTagName("BUTTON")[0].attributes[1].value = "newClass";
            }

            // https://www.w3schools.com/jsref/prop_namednodemap_length.asp
            {
                var x = document.getElementsByTagName("BUTTON")[0].attributes.length;
            }
            {
                var txt = "";
                var x = document.getElementById("myBtn").attributes;

                for (var i = 0; i < x.length; i++)
                {
                    txt += "Attribute name: " + x[i].name + "<br>";
                }
            }
            {
                var x = document.getElementById("myImg").attributes.length;
            }
            {
                var txt = "";
                var x = document.getElementById("myImg");

                for (var i = 0; i < x.attributes.length; i++)
                {
                    txt = txt + x.attributes[i].name + " = " + x.attributes[i].value + "<br>";
                }
            }
        }
    }
}
