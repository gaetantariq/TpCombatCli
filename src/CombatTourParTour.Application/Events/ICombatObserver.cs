namespace CombatTourParTour.Application.Events;

public interface ICombatObserver
{
    void Notifier(string message);
}