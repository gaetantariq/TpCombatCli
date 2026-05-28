using CombatTourParTour.Domain.ValueObjects;

namespace CombatTourParTour.Domain.Entites;

public abstract class Personnage
{
    public string Nom {get; protected set ;}
    public PointsDeVie Pv {get; protected set;}

    protected Personnage(string nom, int pvMax)
    {
        Nom = nom;
        Pv = new PointsDeVie(pvMax);
    }
    /// Indique si le personnage a encore des points de vie.
    public bool EstVivant => Pv.JaugeActuelle > 0;
}
