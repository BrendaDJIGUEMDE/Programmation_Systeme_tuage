
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PassePlat : Sujet {

    /// <summary>
    /// Private constructor of the Singleton without args
    /// </summary>
    private PassePlat() {
    }

    private static PassePlat Instance;

    // TODO A faire
    private int BufferPlatReady;

    /// <summary>
    /// Creation and return of the singleton without args
    /// </summary>
    public static PassePlat GetInstance() {
        if(Instance is null)
        {
            Instance = new PassePlat();
        }
        return Instance;
    }

    public void GetBufferPlatReady() {
        // TODO implement here
    }

    public void AddToBuffer() {
        // TODO implement here
    }

    public void RemoveFromBuffer() {
        // TODO implement here
    }

}