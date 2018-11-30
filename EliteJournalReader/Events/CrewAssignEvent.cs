using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When Written: when changing the task assignment of a member of crew
    //Parameters:
    //�	Name
    //�	Role
    public class CrewAssignEvent : JournalEvent<CrewAssignEvent.CrewAssignEventArgs>
    {
        public CrewAssignEvent() : base("CrewAssign") { }

        public class CrewAssignEventArgs : JournalEventArgs
        {
            public string Name { get; set; }
            public int CrewID { get; set; }
            public string Role { get; set; }
        }
    }
}
