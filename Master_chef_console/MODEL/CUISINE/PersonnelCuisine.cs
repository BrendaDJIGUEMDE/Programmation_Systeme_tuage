
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PersonnelCuisine {

    /// <summary>
    /// Crée un personne de cuisine
    /// ilt faut un deux arguments
    ///  une string pour le nom
    ///  uns string pour le prenom
    /// A la création le isBusy doit etre false
    /// @param String nom
    /// @param String prenom
    /// </summary>s
    public PersonnelCuisine(String nom, String prenom) {
        this.Nom = nom;
        this.Prenom = prenom;
        this.isBusy = false;
    }

    protected String Nom;

    protected String Prenom;

    protected bool isBusy;


    /// <summary>
    /// Retourne le string Nom
    /// </summary>
    public String GetNom() {
        return this.Nom;
    }
    
    /// <summary>
    /// Retourne le string prenom
    /// </summary>
    public String GetPrenom() {
        return this.Prenom;
    }

    /// <summary>
    /// Retourne le isBusy
    /// </summary>s
    public bool GetIsBusy() {
        return this.isBusy;
    }

    /// <summary>
    /// Set le boolean busy a true ou false
    ///  true : il est actuellement occuper
    ///  false : il est actuellement libre
    /// @param bool status
    /// </summary>
    public void SetIsBusy(bool isBusy) {
        this.isBusy = isBusy;
    }

}