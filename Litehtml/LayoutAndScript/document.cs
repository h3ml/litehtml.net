using Litehtml.Events;
using Litehtml.Script;
using System;

namespace Litehtml
{
    partial class document : nodeList, IDocument
    {
        internal object windowProxy;

        IElement IDocument.activeElement => throw new NotImplementedException();
        HTMLCollection IDocument.anchors => throw new NotImplementedException();
        HTMLCollection IDocument.applets => throw new NotImplementedException();
        string IDocument.baseURI => throw new NotImplementedException();
        IElement IDocument.body { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDocument.cookie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDocument.characterSet => throw new NotImplementedException();
        IWindow IDocument.defaultView => throw new NotImplementedException();
        string IDocument.designMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IDocumentType IDocument.doctype => throw new NotImplementedException();
        IElement IDocument.documentElement => throw new NotImplementedException();
        string IDocument.documentURI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDocument.domain => throw new NotImplementedException();
        HTMLCollection IDocument.embeds => throw new NotImplementedException();
        HTMLCollection IDocument.forms => throw new NotImplementedException();
        IElement IDocument.fullscreenElement => throw new NotImplementedException();
        IElement IDocument.head => throw new NotImplementedException();
        HTMLCollection IDocument.images => throw new NotImplementedException();
        DocumentImplementation IDocument.implementation => throw new NotImplementedException();
        string IDocument.inputEncoding => throw new NotImplementedException();
        DateTime IDocument.lastModified => throw new NotImplementedException();
        HTMLCollection IDocument.links => throw new NotImplementedException();
        string IDocument.readyState => throw new NotImplementedException();
        string IDocument.referrer => throw new NotImplementedException();
        HTMLCollection IDocument.scripts => throw new NotImplementedException();
        bool IDocument.strictErrorChecking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDocument.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IDocument.URL => throw new NotImplementedException();
        void IDocument.addEventListener(string @event, string function, bool useCapture) => throw new NotImplementedException();
        INode IDocument.adoptNode(INode node) => throw new NotImplementedException();
        void IDocument.close() => throw new NotImplementedException();
        INode IDocument.createAttribute(string attributename) => throw new NotImplementedException();
        INode IDocument.createComment(string text) => throw new NotImplementedException();
        IDocumentFragment IDocument.createDocumentFragment() => throw new NotImplementedException();
        IElement IDocument.createElement(string nodename) => throw new NotImplementedException();
        Event IDocument.createEvent(string type) => throw new NotImplementedException();
        INode IDocument.createTextNode(string text) => throw new NotImplementedException();
        bool IDocument.execCommand(string command, bool showUI, object value) => throw new NotImplementedException();
        bool IDocument.fullscreenEnabled() => throw new NotImplementedException();
        IElement IDocument.getElementById(string elementID) => throw new NotImplementedException();
        INodeList IDocument.getElementsByClassName(string classname) => throw new NotImplementedException();
        INodeList IDocument.getElementsByName(string name) => throw new NotImplementedException();
        INodeList IDocument.getElementsByTagName(string tagname) => throw new NotImplementedException();
        bool IDocument.hasFocus() => throw new NotImplementedException();
        INode IDocument.importNode(INode node, bool deep) => throw new NotImplementedException();
        void IDocument.normalize() => throw new NotImplementedException();
        void IDocument.open(string MIMEtype, string replace) => throw new NotImplementedException();
        IElement IDocument.querySelector(string selectors) => throw new NotImplementedException();
        INodeList IDocument.querySelectorAll(string selectors) => throw new NotImplementedException();
        void IDocument.removeEventListener(string @event, string function, bool useCapture) => throw new NotImplementedException();
        INode IDocument.renameNode(INode node, string namespaceURI, string nodename) => throw new NotImplementedException();
        void IDocument.write(params object[] args) => throw new NotImplementedException();
        void IDocument.writeln(params object[] args) => throw new NotImplementedException();
    }
}
