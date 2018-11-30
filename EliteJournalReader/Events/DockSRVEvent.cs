using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when docking an SRV with the ship
    //Parameters: none
    public class DockSRVEvent : JournalEvent<DockSRVEvent.DockSRVEventArgs>
    {
        public DockSRVEvent() : base("DockSRV") { }

        public class DockSRVEventArgs : JournalEventArgs
        {
        }
    }
}
