using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Serveur : Personnel
    {
        public Serveur(String Nom, String Prenom) : base(Nom, Prenom)
        {
            Rang = null;
        }

        //private String Nom;

        //private String Prenom;

        private Rangs Rang;

        public void SetRang(Rangs Rang)
        {
            this.Rang = Rang;
        }

        public Rangs GetRang()
        {
            return this.Rang;
        }

        /// <summary>
        /// Le Serveur debarasse
        /// </summary>

        public void Debarasse(Tables table)
        {
            //Transmet aux presentoire salle un nb couvert proportionels a Table.NBpersonnes

        }

        /// <summary>
        /// @param Commande
        /// </summary>
        public void AmenerSucre(Commandes Commande)
        {
            // TODO implement here
        }

        /// <summary>
        /// @param Commande
        /// </summary>
        public void AmenerSale(Commandes Commande)
        {
            Tables TableAServir = Commande.GetTable();
            Clients ClientsAServir = TableAServir.GetClients();
            ClientsAServir.SetServi(true);
            //Timer (gerer par winform)
        }

        /// <summary>
        /// @param Commande
        /// </summary>
        public int Addition()
        {
            return 10;
        }



    }
}
