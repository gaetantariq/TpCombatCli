namespace CombatTourParTour.Application.Etats;

/// Contrat pour définir un état du combat.
public interface IEtatCombat
{

    /// Exécute la logique correspondant à l'état actuel .
    void Executer();
}