using System.Linq;
using CombatTourParTour.Application.Combat;
using CombatTourParTour.Domain.Services;

namespace CombatTourParTour.Application.Actions;

public class AttaqueBasiqueAction : ICombatAction
{
    public string Nom => "Attaque de base";

    public bool PeutExecuter(CombatSession session)
    {
        // L'action est possible s'il y a au moins un ennemi vivant
        return session.Ennemis.Any(e => e.EstVivant);
    }

    public CombatResult Executer(CombatSession session)
    {
        // Pour simplifier l'exemple, on cible le premier ennemi vivant
        var cible = session.Ennemis.First(e => e.EstVivant);
        
        var calculateur = new CalculateurDegats();
        var degats = calculateur.Calculer(session.Heros.AttaqueDeBase);
        
        cible.Pv.SubirAttaque(degats);

        string message = $"{session.Heros.Nom} attaque {cible.Nom} et lui inflige {degats.Valeur} dégâts.";
        
        if (!cible.EstVivant)
        {
            message += $" {cible.Nom} est vaincu !";
        }

        return new CombatResult { Succes = true, Message = message };
    }
}