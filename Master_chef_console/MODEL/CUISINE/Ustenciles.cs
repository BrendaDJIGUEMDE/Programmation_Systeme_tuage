
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Ustenciles {

    /// <summary>
    /// Private constructor of the Singleton without args
    /// </summary>
    private Ustenciles()
    {
        this.Casseroles = 0;
        this.Poels = 0;
        this.CuilliereBois = 0;
        this.PresseAgrumes = 0;
        this.BolSalades = 0;
        this.Tamis = 0;
        this.Entoinnoirs = 0;
        this.Couteaux = 0;
    }

    /// <summary>
    /// Private constructor of the Singleton with args
    /// </summary>
    private Ustenciles(int casseroles, int poels, int cuillireBois, int bolSalades, int PressesAgrumes, int tamis, int entonnoirs, int couteaux)
    {
        this.Casseroles = casseroles;
        this.Poels = poels;
        this.CuilliereBois = cuillireBois;
        this.PresseAgrumes = PressesAgrumes;
        this.BolSalades = bolSalades;
        this.Tamis = tamis;
        this.Entoinnoirs = entonnoirs;
        this.Couteaux = couteaux;
    }

    private int Casseroles;

    private int Poels;

    private int CuilliereBois;

    private int BolSalades;

    private int PresseAgrumes;

    private int Tamis;

    private int Entoinnoirs;

    private int Couteaux;

    private static Ustenciles Instance;


    /// <summary>
    /// Return the number of casseroles
    /// </summary>
    /// <returns></returns>
    public int GetCasseroles()
    {
        return this.Casseroles;
    }

    /// <summary>
    /// Chnage the number of casseroles
    /// </summary>
    /// <param name="nb"></param>
    public void SetCasseroles(int nb) {
        this.Casseroles += nb;
    }

    /// <summary>
    /// Return the number of poels
    /// </summary>
    /// <returns></returns>
    public int GetPoels() {
        return this.Poels;
    }

    /// <summary>
    /// Change the number of Poels
    /// </summary>
    /// <param name="nb"></param>
    public void SetPoels(int nb) {
        this.Poels += nb;
    }

    /// <summary>
    /// Return the number of wood spoon
    /// </summary>
    public int GetCuilliereBois() {
        return this.CuilliereBois;
    }

    /// <summary>
    /// Change the number of wood spoon
    /// </summary>
    /// <param name="nb"></param>
    public void SetCuilliereBois(int nb) {
        this.CuilliereBois += nb;
    }

    /// <summary>
    /// Return the number of BolSalades
    /// </summary>
    /// <returns></returns>
    public int GetBolSalades() {
        return this.BolSalades;
    }

    /// <summary>
    /// Change the number of BolSalades
    /// </summary>
    /// <param name="nb"></param>
    public void SetBolSalades(int nb) {
        this.BolSalades += nb;
    }

    /// <summary>
    /// Return the number of PresseAgrumes
    /// </summary>
    /// <returns></returns>
    public int GetPresseAgrumes() {
        return this.PresseAgrumes;
    }

    /// <summary>
    /// Change the number of PresseAgrumes
    /// </summary>
    /// <param name="nb"></param>
    public void SetPresseAgrumes(int nb) {
        this.PresseAgrumes += nb;
    }
    
    /// <summary>
    /// Return the number of tamis
    /// </summary>
    /// <returns></returns>
    public int GetTamis() {
        return this.Tamis;
    }

    /// <summary>
    /// Change the number of tamis
    /// </summary>
    /// <param name="nb"></param>
    public void SetTamis(int nb) {
        this.Tamis += nb;
    }

    /// <summary>
    /// Return the nymber of entonnoirs
    /// </summary>
    /// <returns></returns>
    public int GetEntoinnoirs() {
        return this.Entoinnoirs;
    }

    /// <summary>
    /// Chnage the number of entonnoirs
    /// </summary>
    /// <param name="nb"></param>
    public void SetEntoinnoirs(int nb) {
        this.Entoinnoirs += nb;
    }

    /// <summary>
    /// Return the number of knives
    /// </summary>
    /// <returns></returns>
    public int GetCouteaux() {
        return this.Couteaux;
    }

    /// <summary>
    /// Change the number of knives
    /// </summary>
    /// <param name="nb"></param>
    public void SetCouteaux(int nb) {
        this.Couteaux += nb;
    }

    /// <summary>
    /// Creation and return of the singleton without args
    /// </summary>
    public static Ustenciles GetInstance() {
        if(Instance is null)
        {
            Instance = new Ustenciles();
        }
        return Instance;
    }

    /// <summary>
    /// Creation and return of the singleton with args
    /// </summary>
    public static Ustenciles GetInstance(int casseroles, int poels, int cuillireBois, int bolSalades, int PressesAgrumes, int tamis, int entonnoirs, int couteaux) {
        if (Instance is null)
        {
            Instance = new Ustenciles(casseroles, poels, cuillireBois, bolSalades, PressesAgrumes, tamis, entonnoirs, couteaux);
        }
        return Instance;
    }

}