using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EliteJournalReader.Events
{
    //When written: when selecting a star system to jump to
    //Note, when following a multi-jump route, this will typically appear for the next star, 
    //during a jump, ie after �StartJump� but before the �FSDJump�
    //Parameters:
    //�	Starsystem
    //�	Name

    public class FSDTargetEvent : JournalEvent<FSDTargetEvent.FSDTargetEventArgs>
    {
        public FSDTargetEvent() : base("FSDTarget") { }

        public class FSDTargetEventArgs : JournalEventArgs
        {
            public string StarSystem { get; set; }
            public long SystemAddress { get; set; }
        }
    }
}
