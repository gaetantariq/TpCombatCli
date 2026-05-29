using CombatTourParTour.Domain.Enums;
using CombatTourParTour.Domain.ValueObjects;

namespace CombatTourParTour.Domain.Entites;

public class Heros : Personnage
{
    public ClasseHeros Classe { get; private set; }
    public int AttaqueDeBase { get; private set; }

    public Heros(string nom, int pvTotal, int attaqueDebase, ClasseHeros classe) : base(nom, pvTotal)
    {
        AttaqueDeBase = attaqueDebase;
        Classe = classe;
    }
}