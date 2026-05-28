using System.Collections.Generic;
using CombatTourParTour.Domain.Entites;

namespace CombatTourParTour.Application.Combat;


/// Contexte global du combat. 
/// Contient le héros, les ennemis actuels et le numéro de la vague.

public class CombatSession
{
    public Heros Heros { get; private set; }
    public List<Ennemi> Ennemis { get; private set; }
    public int VagueActuelle { get; private set; }
    public bool EstTermine { get; set; }

    public CombatSession(Heros heros, List<Ennemi> ennemisVague1)
    {
        Heros = heros;
        Ennemis = ennemisVague1;
        VagueActuelle = 1;
        EstTermine = false;
    }

    /// Met à jour la session avec la vague d'ennemis suivante.

    public void LancerVagueSuivante(List<Ennemi> nouveauxEnnemis)
    {
        VagueActuelle++;
        Ennemis = nouveauxEnnemis;
    }
}