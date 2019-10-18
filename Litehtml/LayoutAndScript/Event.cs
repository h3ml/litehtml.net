namespace Litehtml.Events
{
    partial class Event
    {
        public object Target { get; set; }
        public object CurrentTarget { get; set; }
        public char EventPhase { get; set; }

        public void resetBeforeDispatch()
        {

        }

        public void resetAfterDispatch()
        {

        }
    }
}
