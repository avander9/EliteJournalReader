using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when cockpit canopy is breached
    //Parameters: none
    public class CockpitBreachedEvent : JournalEvent<CockpitBreachedEvent.CockpitBreachedEventArgs>
    {
        public CockpitBreachedEvent() : base("CockpitBreached") { }

        public class CockpitBreachedEventArgs : JournalEventArgs
        {
        }
    }
}
