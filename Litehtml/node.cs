using System;

namespace Litehtml
{
    /// <summary>
    /// node
    /// </summary>
    /// <seealso cref="Litehtml.Node" />
    public class node : Node
    {
        protected internal document _doc;

        public Node appendChild(Node node) => throw new NotImplementedException();
        public NamedNodeMap<Attr> attributes => throw new NotImplementedException();
        public string baseURI => throw new NotImplementedException();
        public NodeList childNodes => throw new NotImplementedException();
        public Node cloneNode(bool deep) => throw new NotImplementedException();
        public int compareDocumentPosition(Node node) => throw new NotImplementedException();
        public Node firstChild => throw new NotImplementedException();
        public string getUserData(string key) => throw new NotImplementedException();
        public bool hasAttribute(string attributename) => throw new NotImplementedException();
        public bool hasAttributes() => throw new NotImplementedException();
        public bool hasChildNodes() => throw new NotImplementedException();
        public bool isDefaultNamespace(string namespaceURI) => throw new NotImplementedException();
        public bool isEqualNode(Node node) => throw new NotImplementedException();
        public bool isSameNode(Node node) => throw new NotImplementedException();
        public Node lastChild => throw new NotImplementedException();
        public string lookupNamespaceURI(string prefix) => throw new NotImplementedException();
        public string lookupPrefix(string namespaceURI) => throw new NotImplementedException();
        public Node nextSibling => throw new NotImplementedException();
        public string nodeName => throw new NotImplementedException();
        public int nodeType => throw new NotImplementedException();
        public string nodeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void normalize() => throw new NotImplementedException();
        public Document ownerDocument => throw new NotImplementedException();
        public Node parentNode => throw new NotImplementedException();
        public string prefix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Node previousSibling => throw new NotImplementedException();
        public Node removeChild(Node node) => throw new NotImplementedException();
        public Node replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException();
        public void setUserData(string key, string data, string handler) => throw new NotImplementedException();
        public string textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    /// <summary>
    /// attr
    /// </summary>
    public class attr : Attr
    {
        public NamedNodeMap<Attr> attributes => throw new NotImplementedException();
        public string baseURI => throw new NotImplementedException();
        public NodeList childNodes => throw new NotImplementedException();
        public Node firstChild => throw new NotImplementedException();
        public Node lastChild => throw new NotImplementedException();
        public Node nextSibling => throw new NotImplementedException();
        public string nodeName => throw new NotImplementedException();
        public int nodeType => throw new NotImplementedException();
        public string nodeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Document ownerDocument => throw new NotImplementedException();
        public Node parentNode => throw new NotImplementedException();
        public string prefix { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Node previousSibling => throw new NotImplementedException();
        public string textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name => throw new NotImplementedException();
        public string value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool specified => throw new NotImplementedException();
        public Node appendChild(Node node) => throw new NotImplementedException();
        public Node cloneNode(bool deep = false) => throw new NotImplementedException();
        public int compareDocumentPosition(Node node) => throw new NotImplementedException();
        public string getUserData(string key) => throw new NotImplementedException();
        public bool hasAttribute(string attributename) => throw new NotImplementedException();
        public bool hasAttributes() => throw new NotImplementedException();
        public bool hasChildNodes() => throw new NotImplementedException();
        public bool isDefaultNamespace(string namespaceURI) => throw new NotImplementedException();
        public bool isEqualNode(Node node) => throw new NotImplementedException();
        public bool isSameNode(Node node) => throw new NotImplementedException();
        public string lookupNamespaceURI(string prefix) => throw new NotImplementedException();
        public string lookupPrefix(string namespaceURI) => throw new NotImplementedException();
        public void normalize() => throw new NotImplementedException();
        public Node removeChild(Node node) => throw new NotImplementedException();
        public Node replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException();
        public void setUserData(string key, string data, string handler) => throw new NotImplementedException();
    }

    partial class element
    {
        public bool dispatchMouseEvent(PlatformMouseEvent platformEvent, string eventType, int detail, element relatedTarget)
        {
            var mouseEvent = new MouseEvent(eventType, _doc.windowProxy, platformEvent, detail, relatedTarget);
            var didNotSwallowEvent = true;
            //    //Debug.Assert(mouseEvent.target == null || mouseEvent.target != relatedTarget);
            //    dispatchEvent(mouseEvent);
            //    if (mouseEvent.defaultPrevented || mouseEvent.defaultHandled)
            //        didNotSwallowEvent = false;

            //    //if (mouseEvent->type() == eventNames().clickEvent && mouseEvent->detail() == 2)
            //    //{
            //    //    // Special case: If it's a double click event, we also send the dblclick event. This is not part
            //    //    // of the DOM specs, but is used for compatibility with the ondblclick="" attribute. This is treated
            //    //    // as a separate event in other DOM-compliant browsers like Firefox, and so we do the same.
            //    //    // FIXME: Is it okay that mouseEvent may have been mutated by scripts via initMouseEvent in dispatchEvent above?
            //    //    Ref<MouseEvent> doubleClickEvent = MouseEvent::create(eventNames().dblclickEvent,
            //    //        mouseEvent->bubbles() ? Event::CanBubble::Yes : Event::CanBubble::No,
            //    //        mouseEvent->cancelable() ? Event::IsCancelable::Yes : Event::IsCancelable::No,
            //    //        Event::IsComposed::Yes,
            //    //        mouseEvent->view(), mouseEvent->detail(),
            //    //        mouseEvent->screenX(), mouseEvent->screenY(), mouseEvent->clientX(), mouseEvent->clientY(),
            //    //        mouseEvent->modifierKeys(), mouseEvent->button(), mouseEvent->buttons(), mouseEvent->syntheticClickType(), relatedTarget);

            //    //    if (mouseEvent->defaultHandled())
            //    //        doubleClickEvent->setDefaultHandled();

            //    //    dispatchEvent(doubleClickEvent);
            //    //    if (doubleClickEvent->defaultHandled() || doubleClickEvent->defaultPrevented())
            //    //        return false;
            //    //}
            return didNotSwallowEvent;
        }

        //public bool dispatchWheelEvent(PlatformWheelEvent platformEvent)
        //{
        //    var @event = new WheelEvent(platformEvent, document().windowProxy());

        //    // Events with no deltas are important because they convey platform information about scroll gestures
        //    // and momentum beginning or ending. However, those events should not be sent to the DOM since some
        //    // websites will break. They need to be dispatched because dispatching them will call into the default
        //    // event handler, and our platform code will correctly handle the phase changes. Calling stopPropogation()
        //    // will prevent the event from being sent to the DOM, but will still call the default event handler.
        //    // FIXME: Move this logic into WheelEvent::create.
        //    if (!platformEvent.deltaX && !platformEvent.deltaY)
        //        @event.stopImmediatePropagation();

        //    dispatchEvent(@event);
        //    return !@event.defaultPrevented && !@event.defaultHandled;
        //}

        //public bool dispatchKeyEvent(PlatformKeyboardEvent platformEvent)
        //{
        //    var event_ = new KeyboardEvent(platformEvent, document().windowProxy());

        //    var frame = document().frame();
        //    if (frame != null)
        //        if (frame.eventHandler().accessibilityPreventsEventPropagation(event_))
        //            event_.stopImmediatePropagation();

        //    dispatchEvent(event_);
        //    return !event_.defaultPrevented && !event_.defaultHandled;
        //}

        //void dispatchFocusInEvent(string eventType, element oldFocusedElement)
        //{
        //    //Debug.Assert(eventType == eventNames().focusinEvent || eventType == eventNames().DOMFocusInEvent);
        //    dispatchScopedEvent(new FocusEvent(eventType, Event.CanBubble.Yes, Event.IsCancelable.No, document().windowProxy(), 0, oldFocusedElement));
        //}

        //void dispatchFocusOutEvent(string eventType, element newFocusedElement)
        //{
        //    //Debug.Assert(eventType == eventNames().focusoutEvent || eventType == eventNames().DOMFocusOutEvent);
        //    dispatchScopedEvent(new FocusEvent(eventType, Event.CanBubble.Yes, Event.IsCancelable.No, document().windowProxy(), 0, newFocusedElement));
        //}

        //void dispatchFocusEvent(element oldFocusedElement, FocusDirection x)
        //{
        //    var page = document().page();
        //    if (page != null)
        //        page.chrome().client().elementDidFocus(this);
        //    dispatchEvent(new FocusEvent(eventNames().focusEvent, Event.CanBubble.No, Event.IsCancelable.No, document().windowProxy(), 0, WTFMove(oldFocusedElement)));
        //}

        //void dispatchBlurEvent(element newFocusedElement)
        //{
        //    var page = document().page();
        //    if (page != null)
        //        page.chrome().client().elementDidBlur(this);
        //    dispatchEvent(new FocusEvent(eventNames().blurEvent, Event.CanBubble.No, Event.IsCancelable.No, document().windowProxy(), 0, WTFMove(newFocusedElement)));
        //}


        char Element.accessKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //NamedNodeMap Element.attributes => throw new NotImplementedException();
        int Element.childElementCount => throw new NotImplementedException();
        //NodeList Element.childNodes => throw new NotImplementedException();
        HTMLCollection Element.children => throw new NotImplementedException();
        DOMTokenList Element.classList => throw new NotImplementedException();
        string Element.className { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Element.clientHeight => throw new NotImplementedException();
        int Element.clientLeft => throw new NotImplementedException();
        int Element.clientTop => throw new NotImplementedException();
        int Element.clientWidth => throw new NotImplementedException();
        string Element.contentEditable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Element.dir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //Node Element.firstChild => throw new NotImplementedException();
        Node Element.firstElementChild => throw new NotImplementedException();
        string Element.id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Element.innerHTML { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Element.innerText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool Element.isContentEditable => throw new NotImplementedException();
        string Element.lang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //Node Element.lastChild => throw new NotImplementedException();
        Node Element.lastElementChild => throw new NotImplementedException();
        string Element.namespaceURI => throw new NotImplementedException();
        //Node Element.nextSibling => throw new NotImplementedException();
        Node Element.nextElementSibling => throw new NotImplementedException();
        //string Element.nodeName => throw new NotImplementedException();
        //int Element.nodeType => throw new NotImplementedException();
        //string Element.nodeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int Element.offsetHeight => throw new NotImplementedException();
        int Element.offsetWidth => throw new NotImplementedException();
        int Element.offsetLeft => throw new NotImplementedException();
        Node Element.offsetParent => throw new NotImplementedException();
        int Element.offsetTop => throw new NotImplementedException();
        //Document Element.ownerDocument => throw new NotImplementedException();
        //Node Element.parentNode => throw new NotImplementedException();
        Element Element.parentElement => throw new NotImplementedException();
        //Node Element.previousSibling => throw new NotImplementedException();
        Node Element.previousElementSibling => throw new NotImplementedException();
        int Element.scrollHeight => throw new NotImplementedException();
        int Element.scrollLeft => throw new NotImplementedException();
        int Element.scrollTop => throw new NotImplementedException();
        int Element.scrollWidth => throw new NotImplementedException();
        Style Element.style => throw new NotImplementedException();
        int Element.tabIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Element.tagName => throw new NotImplementedException();
        //string Element.textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string Element.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        void Element.addEventListener(string @event, string function, bool useCapture) => addEventListener(@event, null, new EventListenerOptions { capture = useCapture });
        //Node Element.appendChild(Node node) => throw new NotImplementedException();
        void Element.blur() => throw new NotImplementedException();
        void Element.click() => throw new NotImplementedException();
        //Node Element.cloneNode(bool deep) => throw new NotImplementedException();
        //int Element.compareDocumentPosition(Node node) => throw new NotImplementedException();
        bool Element.contains(Node node) => throw new NotImplementedException();
        void Element.exitFullscreen() => throw new NotImplementedException();
        void Element.focus() => throw new NotImplementedException();
        string Element.getAttribute(string attributename) => throw new NotImplementedException();
        Attr Element.getAttributeNode(string attributename) => throw new NotImplementedException();
        Rect Element.getBoundingClientRect() => throw new NotImplementedException();
        NodeList Element.getElementsByClassName(string classname) => throw new NotImplementedException();
        NodeList Element.getElementsByTagName(string tagname) => throw new NotImplementedException();
        //bool Element.hasAttribute(string attributename) => throw new NotImplementedException();
        //bool Element.hasAttributes() => throw new NotImplementedException();
        //bool Element.hasChildNodes() => throw new NotImplementedException();
        void Element.insertAdjacentElement(string position, Element element) => throw new NotImplementedException();
        void Element.insertAdjacentHTML(string position, string text) => throw new NotImplementedException();
        void Element.insertAdjacentText(string position, string text) => throw new NotImplementedException();
        Node Element.insertBefore(Node newnode, Node existingnode) => throw new NotImplementedException();
        //bool Element.isDefaultNamespace(string namespaceURI) => throw new NotImplementedException();
        //bool Element.isEqualNode(Node node) => throw new NotImplementedException();
        //bool Element.isSameNode(Node node) => throw new NotImplementedException();
        //void Element.normalize() => throw new NotImplementedException();
        Element Element.querySelector(string selectors) => throw new NotImplementedException();
        NodeList Element.querySelectorAll(string selectors) => throw new NotImplementedException();
        void Element.removeAttribute(string attributename) => throw new NotImplementedException();
        Attr Element.removeAttributeNode(Attr attributenode) => throw new NotImplementedException();
        //Node Element.removeChild(Node node) => throw new NotImplementedException();
        void Element.removeEventListener(string @event, string function, bool useCapture) => removeEventListener(@event, null, new EventListenerOptions { capture = useCapture });
        //Node Element.replaceChild(Node newnode, Node oldnode) => throw new NotImplementedException();
        void Element.requestFullscreen() => throw new NotImplementedException();
        void Element.scrollIntoView(bool alignTo) => throw new NotImplementedException();
        void Element.setAttribute(string attributename, string attributevalue) => throw new NotImplementedException();
        Attr Element.setAttributeNode(Attr attributenode) => throw new NotImplementedException();
        string Element.toString() => throw new NotImplementedException();
    }
}
