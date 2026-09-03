using System;


Wolf loup1 = new Wolf("Loupardo", 30, 8);
Wolf loup2 = new Wolf("Loupio");

Console.WriteLine("Loup 1");
Console.WriteLine("Nom : " + loup1.Name);
Console.WriteLine("Vie : " + loup1.Health);
Console.WriteLine("Dégâts : " + loup1.Damage);

Console.WriteLine();

Console.WriteLine("Loup 2");
Console.WriteLine("Nom : " + loup2.Name);
Console.WriteLine("Vie : " + loup2.Health);
Console.WriteLine("Dégâts : " + loup2.Damage);


class Wolf
{
    public string Name;
    public int Health;
    public int Damage;

    public Wolf(string name, int health, int damage)
    {
        this.Name = name;
        this.Health = health;
        this.Damage = damage;
    }

    public Wolf(string name) : this(name, 20, 5)
    {
    }
}