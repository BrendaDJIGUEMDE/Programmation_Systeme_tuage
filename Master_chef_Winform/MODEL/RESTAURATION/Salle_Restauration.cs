using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Salle_Restauration
    {
        private Salle_Restauration(Carres CarreUn, Carres CarreDeux, Maitre_Hotel MaitreHotel, Commis_Restau Commis, Tables[] L_table )
        {
            this.CarreUn = CarreUn;
            this.CarreDeux = CarreDeux;
            this.MaitreHotel = Maitre_Hotel.GetInstance("djiguemde", "brenda");
            this.Commis = Commis_Restau.GetInstance("djiguemde", "brenda");
            this.L_table = L_table;
            

        }

        private static Salle_Restauration instance = null;

        private Carres CarreUn;

        private Carres CarreDeux;

        private Maitre_Hotel MaitreHotel;

        private Commis_Restau Commis;

        private Tables[] L_table;


        public Carres GetCarreUn()
        {
            return this.CarreUn;
        }

        /// <summary>
        /// Renvoie l'attribut CarreDeux de type Carre
        /// </summary>

        public Carres GetCarreDeux()
        {
            return this.CarreDeux;
        }

        /// <summary>
        /// Renvoie l'attribut MaitreHotel de MaitreHotel
        /// </summary>

        public Maitre_Hotel GetMaitreHotel()
        {
            return this.MaitreHotel;
        }

        /// <summary>
        /// Renvoie l'attribut Commis de type CommisSalle 
        /// </summary>

        public Commis_Restau GetCommis()
        {
            return this.Commis;
        }

        /// <summary>
        /// Methode d'instanciation unique
        /// </summary>
        public static Salle_Restauration GetInstance(Carres CarreUn, Carres CarreDeux, Maitre_Hotel MaitreHotel, Commis_Restau Commis, Tables[] L_table)
        {
            if (Salle_Restauration.instance == null)
            {
                // Arguments :
                //(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
                Salle_Restauration.instance = new Salle_Restauration(CarreUn, CarreDeux, MaitreHotel, Commis, L_table);

            }
            return Salle_Restauration.instance;
        }

    }
}
