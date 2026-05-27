using CombatTourParTour.Domain.ValueObjects;

namespace CombatTourParTour.Domain.Entites;

public class Ennemi : Personnage
{
    public int AttaqueDeBase { get; private set; }

    public Ennemi(string nom, int pvTotal, int attaqueDeBase) 
        : base(nom, pvTotal)
    {
        AttaqueDeBase = attaqueDeBase;
    }
}