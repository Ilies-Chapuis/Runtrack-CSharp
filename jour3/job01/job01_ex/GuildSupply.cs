using System;
using System.Collections.Generic;

namespace Tartaros.Exploration
{

    public partial class GuildSupply
    {

        public List<string> Consumables;


        public GuildSupply()
        {
            Consumables = new List<string>();
            Consumables.Add("Health potion");
            Consumables.Add("Adventure rations");
            Consumables.Add("Torch");
        }
    }
}