using Litehtml.Events;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Litehtml
{
    public class EventTarget
    {
        readonly Dictionary<string, List<EventEntry>> _eventEntries = new Dictionary<string, List<EventEntry>>();

        public delegate void EventListener(object ctx, Event e);

        enum EventInvokePhase
        {
            Capturing,
            Bubbling
        }

        struct EventEntry
        {
            public EventListener listener;
            public EventListenerOptions options;
            public EventEntry(EventListener l, EventListenerOptions o) { listener = l; options = o; }
        }

        public class EventListenerOptions
        {
            public bool capture;
            public bool passive;
            public bool once;
        }

        public bool addEventListener(string eventType, EventListener listener, EventListenerOptions options)
        {
            lock (this)
            {
                if (_eventEntries.TryGetValue(eventType, out var eventEntry))
                {
                    if (eventEntry.Any(x => x.options.capture == options.capture))
                        return false;
                    _eventEntries[eventType].Add(new EventEntry(listener, options));
                    return true;
                }
                _eventEntries[eventType] = new List<EventEntry> { new EventEntry(listener, options) };
                return true;
            }
        }

        public bool removeEventListener(string eventType, EventListener listener, EventListenerOptions options)
        {
            lock (this)
            {
                if (_eventEntries.TryGetValue(eventType, out var eventEntry))
                {
                    var r = eventEntry.RemoveAll(x => x.options.capture == options.capture) > 0;
                    if (eventEntry.Count == 0)
                        _eventEntries.Remove(eventType);
                    return r;
                }
            }
            return false;
        }

        protected void dispatchEvent(Event ev)
        {
            ev.Target = this;
            ev.CurrentTarget = this;
            ev.EventPhase = '@';
            ev.resetBeforeDispatch();
            fireEventListeners(ev, EventInvokePhase.Capturing);
            fireEventListeners(ev, EventInvokePhase.Bubbling);
            ev.resetAfterDispatch();
        }

        void fireEventListeners(Event ev, EventInvokePhase phase)
        {
            if (_eventEntries.TryGetValue(ev.type, out var eventEntry))
                invokeEventListeners(ev, eventEntry, phase);
        }

        void invokeEventListeners(Event ev, IList<EventEntry> listeners, EventInvokePhase phase)
        {
            Debug.Assert(listeners.Count != 0);
            var ctx = (object)null; //scriptExecutionContext
            foreach (var registeredListener in listeners)
            {
                if (phase == EventInvokePhase.Capturing && !registeredListener.options.capture)
                    continue;
                if (phase == EventInvokePhase.Bubbling && registeredListener.options.capture)
                    continue;
                // If stopImmediatePropagation has been called, we just break out immediately, without handling any more events on this target.
                if (ev._immediatePropagationStopped)
                    break;
                // Do this before invocation to avoid reentrancy issues.
                if (registeredListener.options.once)
                    removeEventListener(ev.type, registeredListener.listener, registeredListener.options);
                if (registeredListener.options.passive)
                    ev._inPassiveListener = true;
                registeredListener.listener(ctx, ev);
                if (registeredListener.options.passive)
                    ev._inPassiveListener = false;
            }
        }
    }
}
