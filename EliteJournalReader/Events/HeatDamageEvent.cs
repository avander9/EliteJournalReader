using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when taking damage due to overheating
    //Parameters:none
    public class HeatDamageEvent : JournalEvent<HeatDamageEvent.HeatDamageEventArgs>
    {
        public HeatDamageEvent() : base("HeatDamage") { }

        public class HeatDamageEventArgs : JournalEventArgs
        {
        }
    }
}
