using CombatTourParTour.Application.Combat;

namespace CombatTourParTour.Application.Actions;

public interface ICombatAction
{
    string Nom { get; }
    bool PeutExecuter(CombatSession session);
    CombatResult Executer(CombatSession session);
}