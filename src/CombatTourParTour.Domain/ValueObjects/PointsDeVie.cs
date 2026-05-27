using System;

namespace CombatTourParTour.Domain.ValueObjects;

public class PointsDeVie
{
    public int JaugeTotal { get; private set ;}
    public int JaugeActuelle { get; private set ;}

    public PointsDeVie(int jaugetotal)
    {
        JaugeTotal = jaugetotal ;
        JaugeActuelle = jaugetotal;
    }

    public void SubirAttaque(int attaque)
    {
        if (attaque < 0)
        {
            throw new ArgumentException(" Les attaques(dégâts) ne peuvent opas être négatifs");
        }

        JaugeActuelle -= attaque;

        if (JaugeActuelle < 0)
        {
            JaugeActuelle = 0;
        }

    }

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