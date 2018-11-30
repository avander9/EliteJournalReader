using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Enums;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When Written: when engaging a new member of crew
    //Parameters:
    //�	Name
    public class CrewHireEvent : JournalEvent<CrewHireEvent.CrewHireEventArgs>
    {
        public CrewHireEvent() : base("CrewHire") { }

        public class CrewHireEventArgs : JournalEventArgs
        {
            public int CrewID { get; set; }
            public string Name { get; set; }
            public string Faction { get; set; }
            public int Cost { get; set; }
            public CombatRank CombatRank { get; set; }
        }
    }
}
