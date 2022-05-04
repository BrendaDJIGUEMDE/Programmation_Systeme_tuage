
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stock {

    /// <summary>
    /// Private constructor of the Singleton with args
    /// </summary>
    private Stock(Ingrediant[] ZoneDanree, Ingrediant[] ChambreFroide, Ingrediant[] Congelo) {
        this.ZoneDanree = ZoneDanree;
        this.ChambreFroide = ChambreFroide;
        this.Congelo = Congelo;
    }

    /// <summary>
    /// Private constructor of the Singleton without args
    /// </summary>
    private Stock()
    {
        this.ZoneDanree = null;
        this.ChambreFroide = null;
        this.Congelo = null;
    }

    private Ingrediant[] ZoneDanree;

    private Ingrediant[] ChambreFroide;

    private Ingrediant[] Congelo;

    private static Stock Instance;

    /// <summary>
    /// This should return the list of all the ingrediants that are stocked in ZoneDanree
    /// </summary>
    public Ingrediant[] GetZoneDanree() {
        return this.ZoneDanree;
    }

    /// <summary>
    /// This should return the list of all the ingrediants that are stocked in ChmabreFroide
    /// </summary>
    /// <returns></returns>
    public Ingrediant[] GetChambreFroide() {
        return this.ChambreFroide;
    }

    /// <summary>
    /// This should return the list of all the ingrediants that are stocked in Congelo
    /// </summary>
    /// <returns></returns>
    public Ingrediant[] GetCongelo() {
        return this.Congelo;
    }

    /// <summary>
    /// Creation and return of the singleton without args
    /// </summary>
    public static Stock GetInstance() {
        if(Instance is null) {
            Instance = new Stock();
        }
        return Instance;
    }

    /// <summary>
    /// Creation and return of the singleton with args
    /// </summary>
    public static Stock GetInstance(Ingrediant[] ZoneDanree, Ingrediant[] ChambreFroide, Ingrediant[] Congelo)
    {
        if (Instance is null)
        {
            Instance = new Stock(ZoneDanree, ChambreFroide, Congelo);
        }
        return Instance;
    }

}