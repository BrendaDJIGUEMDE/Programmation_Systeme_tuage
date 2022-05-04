using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCuisine
{
    internal class ChefSucre: PersonnelCuisine
    {
        private static ChefSucre Instance = null;

        /// <summary>
        /// Private constructor of the Singleton
        /// </summary>
        private ChefSucre(String nom = "ERREUR", String prenom = "ERREUR") : base(nom, prenom)
        {
        }


        /// <summary>
        /// Creation and return of the singleton with args
        /// </summary>
        public static ChefSucre GetInstance(String nom, String prenom)
        {
            if (Instance == null)
            {
                ChefSucre.Instance = new ChefSucre(nom, prenom);
            }
            return ChefSucre.Instance;
        }

        /// <summary>
        /// Creation and return of the singleton without args
        /// </summary>
        public static ChefSucre GetInstance()
        {
            if (Instance == null)
            {
                ChefSucre.Instance = new ChefSucre();
            }
            return ChefSucre.Instance;
        }
    }
}
