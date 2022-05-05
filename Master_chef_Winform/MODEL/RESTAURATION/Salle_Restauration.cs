using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Salle_Restauration
    {
        private Salle_Restauration(Carres CarreUn, Carres CarreDeux, Maitre_Hotel MaitreHotel, Commis_Restau Commis, Presentoire_restau PresentoireSalle)
        {
            this.CarreUn = CarreUn;
            this.CarreDeux = CarreDeux;
            this.MaitreHotel = MaitreHotel;
            this.Commis = Commis;
            this.PresentoireSalle = PresentoireSalle;
        }


        private static Salle_Restauration instance = null;


        private Carres CarreUn;

        private Carres CarreDeux;

        private Maitre_Hotel MaitreHotel;

        private Commis_Restau Commis;

        public DateTime Date;



        private Presentoire_restau PresentoireSalle;

        /// <summary>
        /// Renvoie l'attribut CarreUn de type Carre
        /// </summary>

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
        public static Salle_Restauration GetInstance(Carres CarreUn, Carres CarreDeux, Maitre_Hotel MaitreHotel, Commis_Restau Commis, Presentoire_restau PresentoireSalle)
        {
            if (Salle_Restauration.instance == null)
            {
                // Arguments :
                //(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
                Salle_Restauration.instance = new Salle_Restauration(CarreUn, CarreDeux, MaitreHotel, Commis, PresentoireSalle);

            }
            return Salle_Restauration.instance;
        }

        public void Service(Boolean Midi_Soir)
        {
            //false : MIDI ; true : SOIR

            //Regle l'heure

            //Genere les reservations

            //Genere les Clients OU 
            //Le programme va faire arriver les client

        }
    }
}
