using CombatTourParTour.Application.Combat;

namespace CombatTourParTour.Application.Actions;

public class SoinAction : ICombatAction
{
    public string Nom => "Se soigner";
    private const int SOIN_VALEUR = 25;
    private int _utilisationsRestantes = 2; // Règle du TP : 2 utilisations max

    public bool PeutExecuter(CombatSession session)
    {
        return _utilisationsRestantes > 0;
    }

    public CombatResult Executer(CombatSession session)
    {
        if (_utilisationsRestantes <= 0)
        {
            return new CombatResult { Succes = false, Message = "Plus de soins disponibles !" };
        }

        session.Heros.Pv.SeSoigner(SOIN_VALEUR);
        _utilisationsRestantes--;

        return new CombatResult 
        { 
            Succes = true, 
            Message = $"{session.Heros.Nom} se soigne de {SOIN_VALEUR} PV. Soins restants : {_utilisationsRestantes}." 
        };
    }
}