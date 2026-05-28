using CombatTourParTour.Domain.ValueObjects;

namespace CombatTourParTour.Domain.Services;


/// Service du domaine responsable des calculs de dégâts (coups critiques, modificateurs).

public class CalculateurDegats
{

    /// Calcule les dégâts finaux en appliquant un multiplicateur.

    public Degats Calculer(int attaqueDeBase, double multiplicateur = 1.0)
    {
        // On calcule la valeur brute et on l'arrondit 
        int valeurFinale = (int)(attaqueDeBase * multiplicateur);
        
        // On retourne l'objet de valeur sécurisé
        return new Degats(valeurFinale);
    }
}