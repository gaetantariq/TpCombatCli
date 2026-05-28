namespace CombatTourParTour.Domain.ValueObjects;


/// Gère le temps de recharge (en nombre de tours) d'une action de combat.

public class Cooldown
{
    public int ToursMax { get; private set; }
    public int ToursRestants { get; private set; }

    public Cooldown(int toursMax)
    {
        ToursMax = toursMax;
        ToursRestants = 0; // Une compétence est prête à l'emploi au début
    }


    /// Indique si la compétence peut être lancée
    public bool EstPret => ToursRestants == 0;

    
    // Réinitialise le compteur après avoir utilisé la compétence
    public void LancerCooldown()
    {
        ToursRestants = ToursMax;
    }
    /// Diminue le temps d'attente d'un tour 
    public void Diminuer()
    {
        if (ToursRestants > 0)
        {
            ToursRestants--;
        }
    }
}