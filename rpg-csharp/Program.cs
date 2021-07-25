using System;

namespace rpg_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre = new Monstre("Grizzly");
            bool victoire = true;
            bool suivant = false;

            while (!monstre.EstMort())
            {
                // Tour de jeu du Monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                if (monPerso.EstMort())
                {
                    victoire = false;
                    break;
                }
                
                // Tour de jeu du Personnage
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);

                if (victoire)
                {
                    monPerso.gagnerExperience(15);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine(monPerso.Caracteristique());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    while (!suivant)
                    {
                        Console.WriteLine("Salle suivante ? (O/N)");
                        string saisie = Console.ReadLine().ToUpper();
                        if (saisie == "O")
                        {
                            suivant = true;
                            Jouer(monPerso);
                        }
                        else if (saisie == "N")
                        {
                            Environment.Exit(0);
                        }
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("C'est perdu...");
                    Console.ReadKey();
                }
            }
        }
        
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("RPG");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe: ");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Sorcier");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();

            switch ( Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Shaaqx"));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Sorcier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Shaaqx"));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Archer !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Shaaqx"));
                    break;
                case "4":
                    break;
            }
        }
    }
}