using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When Written: when scooping cargo from space or planet surface
    //Parameters:
    //�	Type: cargo type
    //�	Stolen: whether stolen goods
    public class CollectCargoEvent : JournalEvent<CollectCargoEvent.CollectCargoEventArgs>
    {
        public CollectCargoEvent() : base("CollectCargo") { }

        public class CollectCargoEventArgs : JournalEventArgs
        {
            public string Type { get; set; }
            public string Type_Localised { get; set; }
            public bool Stolen { get; set; }
            public int MissionID { get; set; }
        }
    }
}
