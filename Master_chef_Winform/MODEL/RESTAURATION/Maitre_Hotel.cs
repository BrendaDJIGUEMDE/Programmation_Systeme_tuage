using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Maitre_Hotel:Personnel
    {
        private Maitre_Hotel(String Nom = "NOM", String Prenom = "PRENOM") : base(Nom, Prenom)
        {
        }

        private static Maitre_Hotel instance = null;


        //private String Nom;

        //private String Prenom;

        /// <summary>
        /// Methode d'instanciation unique
        /// </summary>

        public static Maitre_Hotel GetInstance(String Nom = null, String Prenom = null)
        {
            if (Maitre_Hotel.instance == null)
            {
                Maitre_Hotel.instance = new Maitre_Hotel(Nom, Prenom);

            }
            return Maitre_Hotel.instance;

        }


        /// <summary>
        /// Le MH defini la table qui sera attribue aux clients et appelle le Chef de rang pour qu'il amene les clients a la table
        /// </summary>

        public Tables AttribueTable(Salle_Restauration Salle, Clients Clients, Boolean AReserve)
        {
            //defini la table (si pas de reservation) 
            // si resa (rajouter un if) Table_Attribue = TableReserve.Table   << !!

            Carres CarreTemp = null;
            Rangs Rangtemp = null;
            Tables Table_attribue = null;
            Chef_Rang CR_Table = null;
            Boolean Table_vide = false;

            int Carre = 1;

            //balaye les differents rang
            //if (TableReserve == false)
            //{
            while (Table_vide == false)
            {

                switch (Carre)
                {
                    case 1:
                        //Rang UN
                        CarreTemp = Salle.GetCarreUn();
                        Rangtemp = CarreTemp.GetRangUn();
                        break;
                    case 2:
                        //Rang DEUX
                        //CarreTemp = Salle.GetCarreUn();
                        Rangtemp = CarreTemp.GetRangDeux();
                        break;
                    case 3:
                        //Rang TROIS
                        CarreTemp = Salle.GetCarreDeux();
                        Rangtemp = CarreTemp.GetRangUn();
                        break;

                    case 4:
                        //Rang QUATRE
                        //CarreTemp = Salle.GetCarreDeux();
                        Rangtemp = CarreTemp.GetRangDeux();
                        break;

                    case 5:
                        //pas de table dispo
                        //Message GUI
                        break;
                }


                foreach (Tables TBLE in Rangtemp.GetListeTables())
                {
                    if ((TBLE.GetNombrePersonnes() == 0) && (Clients.GetNBClients() <= TBLE.GetNombreChaises()))
                    {
                        Table_vide = true;
                        Table_attribue = TBLE;
                        break;
                    }
                }
                Carre++;
            }
            //}

            //Demander au CR concerné 
            CR_Table = Rangtemp.GetChefRang();

            CR_Table.PlaceClient(Table_attribue, Clients);

            return Table_attribue;

        }

        /// <summary>
        /// le MH appelle le Chef de rang pour qu'il amene les clients a la table qu'il a reservé
        /// 
        /// @param Reservation
        /// </summary>
        /// 

        /*
        public void AttribueTable() {
        }*/

    }
}
