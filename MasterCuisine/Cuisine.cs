using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCuisine
{
    internal class Cuisine
    {
        private Armoire Armoire = null;

        private static Cuisine Instance = null;

        private Stock Stock;

        private Machines[] Machines;

        private Ustenciles Ustenciles;

        private PassePlat PassePlat;

        /// <summary>
        /// Private constructor of the Singleton without args
        /// </summary>
        private Cuisine(Stock stock, Machines[] machines, Ustenciles ustenciles, PassePlat passePlat)
        {
            this.Stock = stock;
            this.Machines = machines;
            this.Ustenciles = ustenciles;
            this.PassePlat = passePlat;
        }

        /// <summary>
        /// Private constructor of the Singleton without args
        /// </summary>
        private Cuisine()
        {
            this.Stock = null;
            this.Machines = null;
            this.Ustenciles = null;
            this.PassePlat = null;
        }

        /// <summary>
        /// Return the Amoire
        /// </summary>
        /// <returns></returns>
        public Armoire GetArmoire()
        {
            return this.Armoire;
        }

        /// <summary>
        /// Creation and return of the singleton with args
        /// </summary>
        public static Cuisine GetInstance(Stock stock, Machines[] machines, Ustenciles ustenciles, PassePlat passePlat)
        {
            if (Instance == null)
            {
                Cuisine.Instance = new Cuisine(stock, machines, ustenciles, passePlat);
            }
            return Cuisine.Instance;
        }

        /// <summary>
        /// Creation and return of the singleton without args
        /// </summary>
        public static Cuisine GetInstance()
        {
            if (Instance == null)
            {
                Cuisine.Instance = new Cuisine();
            }
            return Cuisine.Instance;
        }

        /// <summary>
        /// Return the stock
        /// </summary>
        /// <returns></returns>
        public Stock GetStock()
        {
            return this.Stock;
        }

        /// <summary>
        /// Return an array with all the machines
        /// </summary>
        /// <returns></returns>
        public Machines[] GetMachines()
        {
            return this.Machines;
        }

        /// <summary>
        /// Return all the Ustenciles
        /// </summary>
        /// <returns></returns>
        public Ustenciles GetUstenciles()
        {
            return this.Ustenciles;
        }


        /// <summary>
        /// Return the PassePlat
        /// </summary>
        /// <returns></returns>
        public PassePlat GetPassePlat()
        {
            return this.PassePlat;
        }
    }
}
