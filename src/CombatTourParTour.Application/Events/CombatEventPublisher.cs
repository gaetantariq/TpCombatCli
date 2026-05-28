using System.Collections.Generic;

namespace CombatTourParTour.Application.Events;

public class CombatEventPublisher
{
    private readonly List<ICombatObserver> _observateurs = new();

    public void AjouterObservateur(ICombatObserver observateur)
    {
        _observateurs.Add(observateur);
    }

    public void Publier(string message)
    {
        foreach (var obs in _observateurs)
        {
            obs.Notifier(message);
        }
    }
}