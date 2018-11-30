using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when a ship-launched fighter is destroyed
    //Parameters: none
    public class FighterDestroyedEvent : JournalEvent<FighterDestroyedEvent.FighterDestroyedEventArgs>
    {
        public FighterDestroyedEvent() : base("FighterDestroyed") { }

        public class FighterDestroyedEventArgs : JournalEventArgs
        {
        }
    }
}
