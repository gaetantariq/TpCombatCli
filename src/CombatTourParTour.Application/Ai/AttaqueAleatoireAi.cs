using CombatTourParTour.Application.Combat;
using CombatTourParTour.Domain.Entites;
using CombatTourParTour.Domain.Services;

namespace CombatTourParTour.Application.Ai;

public class AttaqueAleatoireAi : IAiStrategy
{
    public CombatResult ExecuterTour(Ennemi ennemi, CombatSession session)
    {
        // L'ennemi attaque toujours le héros
        var calculateur = new CalculateurDegats();
        var degats = calculateur.Calculer(ennemi.AttaqueDeBase);
        
        session.Heros.Pv.SubirAttaque(degats);

        string message = $"{ennemi.Nom} attaque {session.Heros.Nom} et inflige {degats.Valeur} dégâts.";
        
        if (!session.Heros.EstVivant)
        {
            message += $" {session.Heros.Nom} est mort...";
        }

        return new CombatResult { Succes = true, Message = message };
    }
}