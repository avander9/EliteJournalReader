using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteJournalReader.Events.Base;
using EliteJournalReader.Items;
using Newtonsoft.Json.Linq;

namespace EliteJournalReader.Events
{
    //When Written: when requesting an engineer upgrade
    //Parameters:
    //�	Engineer: name of engineer
    //�	Blueprint: name of blueprint
    //�	Level: crafting level
    //�	Ingredients: JSON object with names and quantities of materials required
    public class EngineerCraftEvent : JournalEvent<EngineerCraftEvent.EngineerCraftEventArgs>
    {
        public EngineerCraftEvent() : base("EngineerCraft") { }

        public class EngineerCraftEventArgs : JournalEventArgs
        {
            public string Engineer { get; set; }
            public long EngineerID { get; set; }
            public string Blueprint { get; set; }
            public long BlueprintID { get; set; }
            public int Level { get; set; }
            public double Quality { get; set; }
            public string ApplyExperimentalEffect { get; set; }
            public List<Material> Ingredients { get; set; }
            public List<EngineeringModifiers> Modifiers { get; set; }
        }
    }
}
