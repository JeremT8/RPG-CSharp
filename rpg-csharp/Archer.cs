namespace rpg_csharp
{
    public class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 22;
        }
        
    }
}