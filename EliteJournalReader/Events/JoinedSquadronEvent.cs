using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    public class JoinedSquadronEvent : JournalEvent<JoinedSquadronEvent.JoinedSquadronEventArgs>
    {
        public JoinedSquadronEvent() : base("JoinedSquadron") { }

        public class JoinedSquadronEventArgs : JournalEventArgs
        {
            public string SquadronName { get; set; }
        }
    }
}
