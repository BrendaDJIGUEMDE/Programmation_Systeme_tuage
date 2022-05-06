using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Chef_Rang 
    {
       
        /*
        //private String Nom;

        //private String Prenom;

        private Rangs Rang;

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



        }*/

        string MoveToTable = "Bonjour je suis le chef de rang, suivez moi et veuillez prendre place..";
        string PresenterCarteResto = "Les clients consultent la carte et passent leur commande..";
        string PasserChefCuisine = "Le chef de rang transmet la commande au chef de lka cuisine..";
        string DresserTable = "Le chef de rang transmet la commande au chef de la cuisine..";
        public string getMoveToTable()
        {
            return MoveToTable;
        }
        public string getpresenterCarteResto()
        {
            return PresenterCarteResto;
        }

        public string getPasserChefCuisine()
        {
            return PasserChefCuisine;
        }

        public string getDresserTable()
        {
            return DresserTable;
        }
       
        
    }
}
