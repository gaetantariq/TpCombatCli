using System;
using System.Collections.Generic;
using System.Linq;
using CombatTourParTour.Application.Actions;
using CombatTourParTour.Application.Ai;
using CombatTourParTour.Application.Combat;
using CombatTourParTour.Application.Factories;
using CombatTourParTour.Domain.Enums;

Console.WriteLine("=== BIENVENUE DANS LE COMBAT TOUR PAR TOUR ===");
Console.Write("Entrez le nom de votre héros : ");
string nomHeros = Console.ReadLine() ?? "Héros Inconnu";

// 1. Création via les Factories
var herosFactory = new HerosFactory();
var ennemiFactory = new EnnemiFactory();

var heros = herosFactory.Creer(nomHeros, ClasseHeros.Guerrier);

// 2. Création de la première vague
var vague1 = new List<CombatTourParTour.Domain.Entites.Ennemi>
{
    ennemiFactory.CreerGobelin(),
    ennemiFactory.CreerGobelin()
};

// 3. Initialisation du moteur de combat
var session = new CombatSession(heros, vague1);
var engine = new CombatEngine(session);

Console.WriteLine($"\n{heros.Nom} le Guerrier entre dans l'arène avec {heros.Pv.JaugeActuelle} PV !");
Console.WriteLine($"Une vague de {vague1.Count} ennemis approche.");

var attaqueDeBase = new AttaqueBasiqueAction();
var soin = new SoinAction();
var iaEnnemi = new AttaqueAleatoireAi();

int tour = 1;

while (!session.EstTermine)
{
    Console.WriteLine($"\n=== TOUR {tour} ===");
    Console.WriteLine($"{heros.Nom} : {heros.Pv.JaugeActuelle}/{heros.Pv.JaugeTotal} PV");
    
    // 1. Tour du Joueur
    Console.WriteLine("Actions : [1] Attaquer  [2] Se soigner");
    Console.Write("Votre choix : ");
    var choix = Console.ReadLine();

    CombatResult resultatJoueur;
    
    if (choix == "2" && soin.PeutExecuter(session))
    {
        resultatJoueur = soin.Executer(session);
    }
    else
    {
        resultatJoueur = attaqueDeBase.Executer(session);
    }
    
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"> {resultatJoueur.Message}");
    Console.ResetColor();

    // Nettoyage des ennemis morts
    session.Ennemis.RemoveAll(e => !e.EstVivant);

    // Vérification Victoire
    if (!session.Ennemis.Any())
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("VICTOIRE ! Tous les ennemis sont vaincus.");
        Console.ResetColor();
        session.EstTermine = true;
        break;
    }

    // 2. Tour des Ennemis
    Console.WriteLine("\nTour des ennemis...");
    foreach (var ennemi in session.Ennemis)
    {
        var resultatEnnemi = iaEnnemi.ExecuterTour(ennemi, session);
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"< {resultatEnnemi.Message}");
        Console.ResetColor();

        // Vérification Défaite
        if (!session.Heros.EstVivant)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("GAME OVER. Vous avez été vaincu.");
            Console.ResetColor();
            session.EstTermine = true;
            break;
        }
    }
    
    tour++;
}