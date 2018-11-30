﻿using System.Collections.Generic;

namespace EliteJournalReader.Items
{
    public class Faction
    {
        public string Name { get; set; }
        public string FactionState { get; set; }
        public string Government { get; set; }
        public string Government_Localised { get; set; }
        public double Influence { get; set; }
        public string Allegiance { get; set; }
        public string MyReputation { get; set; }
        public bool SquadronFaction { get; set; } = false;
        public bool HappiestSystem { get; set; } = false;
        public bool HomeSystem { get; set; } = false;

        public List<FactionStateChange> PendingStates { get; set; }
        public List<FactionStateChange> RecoveringStates { get; set; }
        public List<FactionStateChange> ActiveStates { get; set; }
    }

    public class FactionStateChange
    {
        public string State { get; set; }
        public int Trend { get; set; }
    }
}
