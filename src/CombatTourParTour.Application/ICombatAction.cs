using CombatTourParTour.Domain.Entites;

namespace CombatTourParTour.Application.Actions;

public interface ICombatAction
{
    // nom de l'action affiché au joueur
    string Nom {get;}

    // on verifie si le perso a le droit d'utiliser cette action
    bool PeutExécuter(Personnage lanceur);

    // applique les effets de l'action sur la cible
    void Executer(Personnage lanceur, Personnage cible);
}