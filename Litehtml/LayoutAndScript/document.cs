using System;

namespace Litehtml
{
    partial class document
    {
        internal object windowProxy;

        Element Document.activeElement => throw new NotImplementedException();
        HTMLCollection Document.anchors => throw new NotImplementedException();
        HTMLCollection Document.applets => throw new NotImplementedException();
        string Document.baseURI => throw new NotImplementedException();
        Element Document.body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Document.cookie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Document.characterSet => throw new NotImplementedException();
        Window Document.defaultView => throw new NotImplementedException();
        string Document.designMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        DocumentType Document.doctype => throw new NotImplementedException();
        Element Document.documentElement => throw new NotImplementedException();
        string Document.documentURI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Document.domain => throw new NotImplementedException();
        HTMLCollection Document.embeds => throw new NotImplementedException();
        HTMLCollection Document.forms => throw new NotImplementedException();
        Element Document.fullscreenElement => throw new NotImplementedException();
        Element Document.head => throw new NotImplementedException();
        HTMLCollection Document.images => throw new NotImplementedException();
        DocumentImplementation Document.implementation => throw new NotImplementedException();
        string Document.inputEncoding => throw new NotImplementedException();
        DateTime Document.lastModified => throw new NotImplementedException();
        HTMLCollection Document.links => throw new NotImplementedException();
        string Document.readyState => throw new NotImplementedException();
        string Document.referrer => throw new NotImplementedException();
        HTMLCollection Document.scripts => throw new NotImplementedException();
        bool Document.strictErrorChecking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Document.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Document.URL => throw new NotImplementedException();
        void Document.addEventListener(string @event, string function, bool useCapture) => throw new NotImplementedException();
        Node Document.adoptNode(Node node) => throw new NotImplementedException();
        void Document.close() => throw new NotImplementedException();
        Node Document.createAttribute(string attributename) => throw new NotImplementedException();
        Node Document.createComment(string text) => throw new NotImplementedException();
        DocumentFragment Document.createDocumentFragment() => throw new NotImplementedException();
        Element Document.createElement(string nodename) => throw new NotImplementedException();
        Event Document.createEvent(string type) => throw new NotImplementedException();
        Node Document.createTextNode(string text) => throw new NotImplementedException();
        bool Document.execCommand(string command, bool showUI, object value) => throw new NotImplementedException();
        bool Document.fullscreenEnabled() => throw new NotImplementedException();
        Element Document.getElementById(string elementID) => throw new NotImplementedException();
        NodeList Document.getElementsByClassName(string classname) => throw new NotImplementedException();
        NodeList Document.getElementsByName(string name) => throw new NotImplementedException();
        NodeList Document.getElementsByTagName(string tagname) => throw new NotImplementedException();
        bool Document.hasFocus() => throw new NotImplementedException();
        Node Document.importNode(Node node, bool deep) => throw new NotImplementedException();
        void Document.normalize() => throw new NotImplementedException();
        void Document.open(string MIMEtype, string replace) => throw new NotImplementedException();
        Element Document.querySelector(string selectors) => throw new NotImplementedException();
        NodeList Document.querySelectorAll(string selectors) => throw new NotImplementedException();
        void Document.removeEventListener(string @event, string function, bool useCapture) => throw new NotImplementedException();
        Node Document.renameNode(Node node, string namespaceURI, string nodename) => throw new NotImplementedException();
        void Document.write(params object[] args) => throw new NotImplementedException();
        void Document.writeln(params object[] args) => throw new NotImplementedException();
    }
}
