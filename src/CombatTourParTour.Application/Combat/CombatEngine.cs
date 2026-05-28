using CombatTourParTour.Application.Etats;

namespace CombatTourParTour.Application.Combat;

public class CombatEngine
{
    public CombatSession Session { get; private set; }
    private IEtatCombat? _etatCourant;

    public CombatEngine(CombatSession session)
    {
        Session = session;
    }

    public void ChangerEtat(IEtatCombat nouvelEtat)
    {
        _etatCourant = nouvelEtat;
        _etatCourant?.Entrer(this);
    }

    public void ExecuterEtatCourant()
    {
        _etatCourant?.Executer(this);
    }
}