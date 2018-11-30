using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when the player's SRV is destroyed
    //Parameters: none
    public class SRVDestroyedEvent : JournalEvent<SRVDestroyedEvent.SRVDestroyedEventArgs>
    {
        public SRVDestroyedEvent() : base("SRVDestroyed") { }

        public class SRVDestroyedEventArgs : JournalEventArgs
        {
        }
    }
}
