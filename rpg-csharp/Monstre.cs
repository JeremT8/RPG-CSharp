namespace rpg_csharp
{
    public class Monstre : Entite 
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointsDeVie = 60;
            this.degatsMin = 7;
            this.degatsMax = 13;
        }
    }
}