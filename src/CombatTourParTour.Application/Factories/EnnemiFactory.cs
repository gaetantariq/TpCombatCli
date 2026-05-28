using System;
using CombatTourParTour.Domain.Entites;

namespace CombatTourParTour.Application.Factories;

public class EnnemiFactory
{
    public Ennemi CreerGobelin()
    {
        return new Ennemi("Gobelin", 40, 5);
    }

    public Ennemi CreerGobelinArcher()
    {
        return new Ennemi("Gobelin Archer", 35, 8);
    }

    public Ennemi CreerBossOrc()
    {
        return new Ennemi("Boss Orc", 150, 15);
    }
}