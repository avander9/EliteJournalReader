using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: at the start of the LoadGame process
    //Parameters:
    //• Name: commander name
    public class CommanderEvent : JournalEvent<CommanderEvent.CommanderEventArgs>
    {
        public CommanderEvent() : base("Commander") { }

        public class CommanderEventArgs : JournalEventArgs
        {
            public string Name { get; set; }
        }
    }
}
