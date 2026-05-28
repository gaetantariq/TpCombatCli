using System;
using CombatTourParTour.Domain.ValueObjects;

namespace CombatTourParTour.Domain.ValueObjects;


/// Représente la jauge de santé d'une entité.
/// Garantit que les valeurs restent toujours positives.

public class PointsDeVie
{
    public int JaugeTotal { get; private set; }
    public int JaugeActuelle { get; private set; }

    public PointsDeVie(int jaugetotal)
    {
        JaugeTotal = jaugetotal;
        JaugeActuelle = jaugetotal;
    }


    /// Réduit la jauge actuelle en fonction des dégâts reçus.

    public void SubirAttaque(Degats degats) 
    {
        // La validation (dégâts < 0) est déjà gérée par l'objet Degats.
        JaugeActuelle -= degats.Valeur;

        if (JaugeActuelle < 0)
        {
            JaugeActuelle = 0;
        }
    }


    /// Restaure la jauge actuelle.
    /// La jauge ne peut pas dépasser son maximum initial.

    public void SeSoigner(int soin)
    {
        if (soin < 0)
        {
            throw new ArgumentException("Le soin ne doit pas être négatif.");
        }
        
        JaugeActuelle += soin;

        if (JaugeActuelle > JaugeTotal)
        {
            JaugeActuelle = JaugeTotal;
        }
    }
}