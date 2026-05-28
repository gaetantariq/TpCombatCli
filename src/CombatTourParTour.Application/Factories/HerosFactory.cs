using System;
using CombatTourParTour.Domain.Entites;
using CombatTourParTour.Domain.Enums;

namespace CombatTourParTour.Application.Factories;

public class HerosFactory
{
    public Heros Creer(string nom, ClasseHeros classe)
    {
        return classe switch
        {
            ClasseHeros.Guerrier => new Heros(nom, 120, 18, classe),
            ClasseHeros.Mage => new Heros(nom, 80, 12, classe),
            ClasseHeros.Voleur => new Heros(nom, 90, 14, classe),
            _ => throw new ArgumentException("Classe de héros invalide.")
        };
    }
}