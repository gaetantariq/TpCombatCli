using CombatTourParTour.Application.Combat;

namespace CombatTourParTour.Application.Commands;

public interface ICommand
{
    void Executer(CombatEngine engine);
}