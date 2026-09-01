static (string Nom, int Age, int Niveau, string Classe, double PiecesOr, bool Nouveau) CreerFiche()
{
    return ("Chapuis", 19, 10, "Assassin", 102, true);
}

static void AfficherFiche((string Nom, int Age, int Niveau, string Classe, double PiecesOr, bool Nouveau) fiche)
{
    Console.WriteLine("Nom : " + fiche.Nom);
    Console.WriteLine("Age : " + fiche.Age);
    Console.WriteLine("Niveau : " + fiche.Niveau);
    Console.WriteLine("Classe : " + fiche.Classe);
    Console.WriteLine("Pièces d'or : " + fiche.PiecesOr);
    Console.WriteLine("Nouveau : " + fiche.Nouveau);
}

var maFiche = CreerFiche();
AfficherFiche(maFiche);