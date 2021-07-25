using System;

namespace rpg_csharp
{
    public abstract class Personnage : Entite
    {
        private int niveau;
        private int experience;

        public Personnage(string nom) : base(nom)
        {
            this.nom = nom;
            niveau = 1;
            experience = 0;
        }

        public void gagnerExperience(int experience)
        {
            this.experience += experience;
            while (this.experience >= experienceRequise())
            {
                niveau += 1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Felicitation, vous avez atteint le niveau " + niveau + "!");

                pointsDeVie += 10;
                degatsMin += 2;
                degatsMax += 2;
            }
        }
        
        public double experienceRequise()
        {
            // Fonction mathématique récuperée du systeme Pokemon
            return Math.Round(4 * (Math.Pow(niveau, 3) / 5));
        }

        public string Caracteristique()
        {
            return this.nom + "\n" +
                   "Point de Vie : " + pointsDeVie + "\n" +
                   "Niveau : " + niveau + "\n" +
                   "Point d'Experience : (" + experience + "/" + experienceRequise() + ")\n" +
                   "Dégats : [" + degatsMin + ";" + degatsMax + "]";
        }
    }
}