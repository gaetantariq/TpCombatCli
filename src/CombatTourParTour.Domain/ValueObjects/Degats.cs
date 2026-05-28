using System;

namespace CombatTourParTour.Domain.ValueObjects;


/// Encapsule la notion de dégâts pour garantir qu'ils ne soient jamais négatifs.

public class Degats
{
    public int Valeur { get; private set; }

    public Degats(int valeur)
    {
        if (valeur < 0)
        {
            throw new ArgumentException("Les dégâts ne peuvent pas être négatifs.");
        }
            
        Valeur = valeur;
    }
}