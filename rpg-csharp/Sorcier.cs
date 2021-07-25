namespace rpg_csharp
{
    public class Sorcier : Personnage
    {
        public Sorcier(string nom) : base(nom)
        {
            pointsDeVie = 90;
            degatsMin = 15;
            degatsMax = 25;
        }
    }
}
