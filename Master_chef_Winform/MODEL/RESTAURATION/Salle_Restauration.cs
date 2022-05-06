using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Salle_Restauration
    {
        /*
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

        }*/

        public Tables[] tables;
        Maitre_Hotel M = new Maitre_Hotel();

        public Salle_Restauration()
        {
            tables = new Tables[33];
            tables[0] = new Tables(2, false);
            tables[1] = new Tables(2, false);
            tables[2] = new Tables(2, false);
            tables[3] = new Tables(2, false);
            tables[4] = new Tables(2, false);
            tables[5] = new Tables(2, false);
            tables[6] = new Tables(2, false);
            tables[7] = new Tables(2, false);
            tables[8] = new Tables(2, false);
            tables[9] = new Tables(2, false);
            tables[10] = new Tables(2, false);
            tables[11] = new Tables(4, false);
            tables[12] = new Tables(4, false);
            tables[13] = new Tables(4, false);
            tables[14] = new Tables(4, false);
            tables[15] = new Tables(4, false);
            tables[16] = new Tables(4, false);
            tables[17] = new Tables(4, false);
            tables[18] = new Tables(4, false);
            tables[19] = new Tables(4, false);
            tables[20] = new Tables(4, false);
            tables[21] = new Tables(4, false);
            tables[16] = new Tables(4, false);
            tables[17] = new Tables(4, false);
            tables[18] = new Tables(4, false);
            tables[19] = new Tables(4, false);
            tables[20] = new Tables(4, false);
            tables[21] = new Tables(6, false);
            tables[22] = new Tables(6, false);
            tables[23] = new Tables(6, false);
            tables[24] = new Tables(6, false);
            tables[25] = new Tables(6, false);
            tables[26] = new Tables(8, false);
            tables[27] = new Tables(8, false);
            tables[28] = new Tables(8, false);
            tables[29] = new Tables(8, false);
            tables[30] = new Tables(8, false);
            tables[31] = new Tables(10, false);
            tables[32] = new Tables(10, false);



        }
        int pos = -1;
        public int getPos()
        {
            return pos;
        }
        public Tables ParcoursTable(int nbreClient)
        {
            Console.WriteLine(tables.Length);
            Thread.Sleep(5000);
            Tables table = new Tables(0, true);
            
            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i].getNbreDePlace() == nbreClient)
                {

                    if (!tables[i].getOccuper())
                    {
                        tables[i].changeOccuper();
                        table = tables[i];
                        pos = i;
                    }
                }
            }

            if (pos == -1)
            {
                for (int i = 0; i < tables.Length; i++)
                {
                    if (tables[i].getNbreDePlace() - 1 == nbreClient)
                    {

                        if (!tables[i].getOccuper())
                        {
                            tables[i].changeOccuper();
                            table = tables[i];
                            pos = i;
                        }
                    }
                }
            }
            Console.WriteLine("Le chef de rang vous conduira à la table " + pos);
            return table;

        }
    }
}
