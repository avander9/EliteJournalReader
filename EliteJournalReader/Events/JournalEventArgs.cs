using System;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class JournalEventArgs : EventArgs
    {
        public JObject OriginalEvent { get; set; }

        public DateTime Timestamp { get; set; }

        public JournalEventArgs()
        {
        }

        public virtual void PostProcess(JObject evt) { }
    }
}