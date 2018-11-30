using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when in multicrew, in Helm player's log, when a crew member launches a fighter
    //Parameters:
    //�	Crew: name of crew member launching in fighter
    public class CrewLaunchFighterEvent : JournalEvent<CrewLaunchFighterEvent.CrewLaunchFighterEventArgs>
    {
        public CrewLaunchFighterEvent() : base("CrewLaunchFighter") { }

        public class CrewLaunchFighterEventArgs : JournalEventArgs
        {
            public string Crew { get; set; }
            public int CrewID { get; set; }
        }
    }
}
