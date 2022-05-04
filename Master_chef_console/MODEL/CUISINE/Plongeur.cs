
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Plongeur : PersonnelCuisine {

    private static Plongeur Instance = null;

    /// <summary>
    /// Private constructor of the Singleton
    /// </summary>
    private Plongeur(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom) {
    }


    /// <summary>
    /// Creation and return of the singleton with args
    /// </summary>
    public static Plongeur GetInstance(String nom, String prenom)
    {
        if (Instance == null)
        {
            Plongeur.Instance = new Plongeur(nom, prenom);
        }
        return Plongeur.Instance;
    }

    /// <summary>
    /// Creation and return of the singleton without args
    /// </summary>
    public static Plongeur GetInstance()
    {
        if (Instance == null)
        {
            Plongeur.Instance = new Plongeur();
        }
        return Plongeur.Instance;
    }
}