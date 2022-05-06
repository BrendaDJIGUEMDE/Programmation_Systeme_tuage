using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Chef_Rang : Personnel
    {
        public Chef_Rang(String Nom, String Prenom) : base(Nom, Prenom)
        {
            Rang = null;
        }

        //private String Nom;

        //private String Prenom;

        private Rangs Rang;

        private static Chef_Rang instance = null;

        /// <summary>
        /// Le CR place les clients
        /// 
        /// @param Table
        /// </summary>
        public void PlaceClient(Tables Table, Clients Clients)
        {
            //MAJ table
            Table.SetNombrePersonnes(Clients.GetNBClients());
            Table.SetClients(Clients);

            //MAJ clients
            //APPELLE PREND commande
            this.PrendCommande(Table);

        }

        /// <summary>
        /// 
        /// </summary>
        public void SetRang(Rangs Rang)
        {
            this.Rang = Rang;
        }

        /// <summary>
        /// 
        /// </summary>

        public Rangs GetRang()
        {
            return this.Rang;
        }

        /// <summary>
        /// Le CR prend la commande d'une table
        /// 
        /// @param Table
        /// </summary>
        public void PrendCommande(Tables Table)
        {
            Clients Cli = null;
            string[] Commande = null;

            Cli = Table.GetClients();
            Commande = Cli.GetCommandes();

            //recup commande
            //la transmet en cuisine
            //Apporte pain et eau
            if (Table.GetHasEau() == false)
            {
                Table.SetHasEau(true);
            }

            if (Table.GetHasPain() == false)
            {
                Table.SetHasPain(true);
            }



        }

        public static Chef_Rang GetInstance(String Nom, String Prenom)
        {
            if (Chef_Rang.instance == null)
            {
                // Arguments :
                //(Carre CarreUn, Carre CarreDeux, MaitreHotel MaitreHotel, CommisSalle Commis, PresentoireSalle PresentoireSalle)
                Chef_Rang.instance = new Chef_Rang( Nom, Prenom);

            }
            return Chef_Rang.instance;
        }

    }
}
