using Tartaros.Exploration;



GuildSupply stock = new GuildSupply();

stock.ShowSupplies();

Console.WriteLine();
stock.UseSupply("Adventure rations");
Console.WriteLine();

stock.ShowSupplies();