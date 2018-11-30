using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class FSSAllBodiesFoundEvent : JournalEvent<FSSAllBodiesFoundEvent.FSSAllBodiesFoundEventArgs>
    {
        public FSSAllBodiesFoundEvent() : base("FSSAllBodiesFound") { }

        public class FSSAllBodiesFoundEventArgs : JournalEventArgs
        {
            public int BodyCount { get; set; }
            public int NonBodyCount { get; set; }
        }
    }
}
