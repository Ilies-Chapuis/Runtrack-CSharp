enum PotionType
{
    Health,
    Mana,
    Stamina
}

class Order
{
    public string ?ClientName { get; set; }
    public PotionType Potion { get; set; }
    public int Quantity { get; set; }
    public string ?Instructions { get; set; }

    public void Display()
    {
        string instructions = string.IsNullOrEmpty(Instructions) ? "Aucune instruction" : Instructions;
        Console.WriteLine($"Commande de {ClientName} : {Quantity}x potion de {Potion} — Instructions : {instructions}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Order o1 = new Order { ClientName = "Melvin", Potion = PotionType.Stamina, Quantity = 5, Instructions = "Avec alcool" };
        Order o2 = new Order { ClientName = "Guillaume", Potion = PotionType.Mana, Quantity = 2 };

        o1.Display();
        o2.Display();
    }
}