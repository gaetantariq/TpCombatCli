using System.Collections.Generic;

namespace CombatTourParTour.Application.Events;

public class JournalCombatObserver : ICombatObserver
{
    public List<string> Historique { get; private set; } = new();

    public void Notifier(string message)
    {
        Historique.Add(message);
    }
}