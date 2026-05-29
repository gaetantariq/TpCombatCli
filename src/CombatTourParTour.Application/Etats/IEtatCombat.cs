using CombatTourParTour.Application.Combat;

namespace CombatTourParTour.Application.Etats;

public interface IEtatCombat
{
    void Entrer(CombatEngine engine);
    void Executer(CombatEngine engine);
}