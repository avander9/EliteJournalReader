using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: When another player leaves your ship's crew
    //Parameters:
    //�	Crew: player's commander name
    public class CrewMemberQuitsEvent : JournalEvent<CrewMemberQuitsEvent.CrewMemberQuitsEventArgs>
    {
        public CrewMemberQuitsEvent() : base("CrewMemberQuits") { }

        public class CrewMemberQuitsEventArgs : JournalEventArgs
        {
            public override void Initialize(JObject evt)
            {
                base.Initialize(evt);
                Crew = evt.Value<string>("Crew");
            }

            public string Crew { get; set; }
        }
    }
}