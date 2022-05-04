
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

public class Machines {

    public Machines(String nom, int capacite) {
        this.Nom = nom;
        this.Capacite = capacite;
        this.Semaphores = new Semaphore(1, 1);
    }

    private DateTime Debut;

    private DateTime DateFin;

    private int Capacite;

    private PersonnelCuisine Proprio;

    private String Nom;


    private Semaphore Semaphores;

    /// <summary>
    /// Function that make the machine run
    /// </summary>
    public void Utilise() {
        // TODO implement here
    }

    /// <summary>
    /// Return the actual person using the machine
    /// </summary>
    public PersonnelCuisine GetProprio() {
        return this.Proprio;
    }

    /// <summary>
    /// Return the name of the machine
    /// </summary>
    public String GetNom() {
        return this.Nom;
    }

    /// <summary>
    /// Set the new prorpio of the machine
    /// </summary>
    /// <param name="proprio"></param>
    public void SetProprio(PersonnelCuisine proprio) {
        this.Proprio = proprio;
    }

    /// <summary>
    /// Set the time of usage of the machine
    /// </summary>
    /// 

    public int start(int s) {
        if(s == 0)
        {
            this.Debut = DateTime.Now;
            this.DateFin = new DateTime(1900, 1, 1);
            Console.WriteLine(Debut);
            Console.WriteLine(DateFin);
            return s;
        }
        else if(s > 0)
        {
            Semaphores.WaitOne();
            this.Debut = DateTime.Now;
            this.DateFin = Debut.AddSeconds(s);
            Thread.Sleep(s*1000);
            Semaphores.Release();
            return s;
        }
        throw new System.ArgumentException("Argument error");

    }

    /// <summary>
    /// Return if the machine is busy or not
    /// To do that it take the StartDate and DateFin and make the difference
    /// </summary>
    /// <returns></returns>
    public bool isRunning()
    {
        if(this.DateFin < DateTime.Now)
        {
            Semaphores.Release();
            return false;
           
        }
        else
        {
            return true;
        }
    }

}