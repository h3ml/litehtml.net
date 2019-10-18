using Litehtml.Events;
using Litehtml.Script;
using System;
using System.Collections.Generic;

namespace Litehtml
{
    partial class element : node, IElement
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


        char IElement.accessKey { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        NamedNodeMap IElement.attributes => throw new NotImplementedException();
        int IElement.childElementCount => throw new NotImplementedException();
        INodeList IElement.childNodes => throw new NotImplementedException();
        HTMLCollection IElement.children => throw new NotImplementedException();
        DOMTokenList IElement.classList => throw new NotImplementedException();
        string IElement.className { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IElement.clientHeight => throw new NotImplementedException();
        int IElement.clientLeft => throw new NotImplementedException();
        int IElement.clientTop => throw new NotImplementedException();
        int IElement.clientWidth => throw new NotImplementedException();
        string IElement.contentEditable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IElement.dir { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        INode IElement.firstChild => throw new NotImplementedException();
        INode IElement.firstElementChild => throw new NotImplementedException();
        string IElement.id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IElement.innerHTML { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IElement.innerText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        bool IElement.isContentEditable => throw new NotImplementedException();
        string IElement.lang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        INode IElement.lastChild => throw new NotImplementedException();
        INode IElement.lastElementChild => throw new NotImplementedException();
        string IElement.namespaceURI => throw new NotImplementedException();
        INode IElement.nextSibling => throw new NotImplementedException();
        INode IElement.nextElementSibling => throw new NotImplementedException();
        string IElement.nodeName => throw new NotImplementedException();
        int IElement.nodeType => throw new NotImplementedException();
        string IElement.nodeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IElement.offsetHeight => throw new NotImplementedException();
        int IElement.offsetWidth => throw new NotImplementedException();
        int IElement.offsetLeft => throw new NotImplementedException();
        INode IElement.offsetParent => throw new NotImplementedException();
        int IElement.offsetTop => throw new NotImplementedException();
        IDocument IElement.ownerDocument => throw new NotImplementedException();
        INode IElement.parentNode => throw new NotImplementedException();
        IElement IElement.parentElement => throw new NotImplementedException();
        INode IElement.previousSibling => throw new NotImplementedException();
        INode IElement.previousElementSibling => throw new NotImplementedException();
        int IElement.scrollHeight => throw new NotImplementedException();
        int IElement.scrollLeft => throw new NotImplementedException();
        int IElement.scrollTop => throw new NotImplementedException();
        int IElement.scrollWidth => throw new NotImplementedException();
        IStyle IElement.style => throw new NotImplementedException();
        int IElement.tabIndex { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IElement.tagName => throw new NotImplementedException();
        string IElement.textContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IElement.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        void IElement.addEventListener(string @event, string function, bool useCapture) => addEventListener(@event, null, new EventListenerOptions { capture = useCapture });
        INode IElement.appendChild(INode node) => throw new NotImplementedException();
        void IElement.blur() => throw new NotImplementedException();
        void IElement.click() => throw new NotImplementedException();
        INode IElement.cloneNode(bool deep) => throw new NotImplementedException();
        int IElement.compareDocumentPosition(INode node) => throw new NotImplementedException();
        bool IElement.contains(INode node) => throw new NotImplementedException();
        void IElement.exitFullscreen() => throw new NotImplementedException();
        void IElement.focus() => throw new NotImplementedException();
        string IElement.getAttribute(string attributename) => throw new NotImplementedException();
        IAttr IElement.getAttributeNode(string attributename) => throw new NotImplementedException();
        IRect IElement.getBoundingClientRect() => throw new NotImplementedException();
        INodeList IElement.getElementsByClassName(string classname) => throw new NotImplementedException();
        INodeList IElement.getElementsByTagName(string tagname) => throw new NotImplementedException();
        bool IElement.hasAttribute(string attributename) => throw new NotImplementedException();
        bool IElement.hasAttributes() => throw new NotImplementedException();
        bool IElement.hasChildNodes() => throw new NotImplementedException();
        void IElement.insertAdjacentElement(string position, IElement element) => throw new NotImplementedException();
        void IElement.insertAdjacentHTML(string position, string text) => throw new NotImplementedException();
        void IElement.insertAdjacentText(string position, string text) => throw new NotImplementedException();
        INode IElement.insertBefore(INode newnode, INode existingnode) => throw new NotImplementedException();
        bool IElement.isDefaultNamespace(string namespaceURI) => throw new NotImplementedException();
        bool IElement.isEqualNode(INode node) => throw new NotImplementedException();
        bool IElement.isSameNode(INode node) => throw new NotImplementedException();
        void IElement.normalize() => throw new NotImplementedException();
        IElement IElement.querySelector(string selectors) => throw new NotImplementedException();
        INodeList IElement.querySelectorAll(string selectors) => throw new NotImplementedException();
        void IElement.removeAttribute(string attributename) => throw new NotImplementedException();
        IAttr IElement.removeAttributeNode(IAttr attributenode) => throw new NotImplementedException();
        INode IElement.removeChild(INode node) => throw new NotImplementedException();
        void IElement.removeEventListener(string @event, string function, bool useCapture) => removeEventListener(@event, null, new EventListenerOptions { capture = useCapture });
        INode IElement.replaceChild(INode newnode, INode oldnode) => throw new NotImplementedException();
        void IElement.requestFullscreen() => throw new NotImplementedException();
        void IElement.scrollIntoView(bool? alignTo) => throw new NotImplementedException();
        void IElement.setAttribute(string attributename, string attributevalue) => throw new NotImplementedException();
        IAttr IElement.setAttributeNode(IAttr attributenode) => throw new NotImplementedException();
        void IElement.toString() => throw new NotImplementedException();
    }
}
