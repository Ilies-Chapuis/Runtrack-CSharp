using System;

namespace Tartaros.Exploration
{

    public partial class GuildSupply
    {

        public void ShowSupplies()
        {
            Console.WriteLine("Stocks");

            foreach (string item in Consumables)
            {
                Console.WriteLine("- " + item);
            }
        }


        public void UseSupply(string itemName)
        {
            if (Consumables.Contains(itemName))
            {
                Consumables.Remove(itemName);
                Console.WriteLine("You used : " + itemName);
            }
            else
            {
                Console.WriteLine("Object not found in inventory : " + itemName);
            }
        }
    }
}