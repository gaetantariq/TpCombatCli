using CombatTourParTour.Domain.ValueObjects;
namespace CombatTourParTour.Domain.Entites;

public class Heros : Personnage
{
    public string classe {get; private set;}
    public int AttaqueDeBase { get; private set; }

    public Heros(string nom, int pvTotal, int attaqueDebase, string classe): base(nom, pvTotal)
    {
        AttaqueDeBase = attaqueDebase;
        classe = classe;
    }
}
