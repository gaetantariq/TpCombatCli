using CombatTourParTour.Application.Combat;
using CombatTourParTour.Domain.Entites;

namespace CombatTourParTour.Application.Ai;

public interface IAiStrategy
{
    CombatResult ExecuterTour(Ennemi ennemi, CombatSession session);
}