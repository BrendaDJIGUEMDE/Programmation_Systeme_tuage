using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCuisine
{
    internal class ChefSale : PersonnelCuisine
    {
        private static ChefSale Instance = null;

        /// <summary>
        /// Private constructor of the Singleton
        /// </summary>
        private ChefSale(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom)
        {
        }


        /// <summary>
        /// Creation and return of the singleton with args
        /// </summary>
        public static ChefSale GetInstance(String nom, String prenom)
        {
            if (Instance == null)
            {
                ChefSale.Instance = new ChefSale(nom, prenom);
            }
            return ChefSale.Instance;
        }

        /// <summary>
        /// Creation and return of the singleton without args
        /// </summary>
        public static ChefSale GetInstance()
        {
            if (Instance == null)
            {
                ChefSale.Instance = new ChefSale();
            }
            return ChefSale.Instance;
        }
    }
}
