using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When written: when approaching a planetary settlement
    //Parameters:
    //�	Name
    public class ApproachSettlementEvent : JournalEvent<ApproachSettlementEvent.ApproachSettlementEventArgs>
    {
        public ApproachSettlementEvent() : base("ApproachSettlement") { }

        public class ApproachSettlementEventArgs : JournalEventArgs
        {
            public string Name { get; set; }
            public long MarketID { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
    }
}
