using CombatTourParTour.Domain.Enums;
using CombatTourParTour.Domain.ValueObjects;
namespace CombatTourParTour.Domain.Entites;

public class Heros : Personnage
{
/// La classe ou le métier du héros.
    // public string classe {get; private set;}
    public ClasseHeros Classe { get; private set; }
     /// La valeur de dégâts de base infligée par une attaque standard
    public int AttaqueDeBase { get; private set; }

    public Heros(string nom, int pvTotal, int attaqueDebase, string classe): base(nom, pvTotal)
    {
        AttaqueDeBase = attaqueDebase;
        classe = classe;
    }
}
