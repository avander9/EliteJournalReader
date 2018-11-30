using System;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class MessageReceivedEventArgs : EventArgs
    {
        public JObject JObject { get; private set; }
        public string EventType { get; private set; }
        public DateTime Timestamp { get; private set; }

        public MessageReceivedEventArgs(JournalEventArgs args, string eventType)
        {
            JObject = args.OriginalEvent?.DeepClone() as JObject;
            EventType = eventType;
            Timestamp = args.Timestamp;
        }
    }
}