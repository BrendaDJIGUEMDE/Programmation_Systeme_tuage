using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Commis_Restau:Personnel
    {
        private Commis_Restau(String Nom = "NOM", String Prenom = "PRENOM") : base(Nom, Prenom)
        {
        }

        private static Commis_Restau instance = null;


        //private String Nom;

        //private String Prenom;

        /// <summary>
        /// Methode d'instanciation unique
        /// </summary>
        public static Commis_Restau GetInstance(String Nom = null, String Prenom = null)
        {
            if (Commis_Restau.instance == null)
            {
                Commis_Restau.instance = new Commis_Restau(Nom, Prenom);
            }
            return Commis_Restau.instance;
        }


        /// <summary>
        /// Le commis amene l'eau
        /// </summary>

        public void AmenerEau(Tables table)
        {
        }

        /// <summary>
        /// Le commis ammene du pain
        /// </summary>

        public void AmenerPain(Tables table)
        {
        }

        /// <summary>
        /// Le commis redresse la table
        /// </summary>

        public void DresserTable(Tables table)
        {
            //check si table debarrassé?
        }

    }
}
