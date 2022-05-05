using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Rangs
    {
        public Rangs(Serveur Serveur, Chef_Rang ChefRang, Tables[] ListeTables)
        {
            //initialisations par défauts
            this.Serveur = Serveur;
            this.ChefRang = ChefRang;
            this.ListeTables = ListeTables;
            Serveur.SetRang(this);
            ChefRang.SetRang(this);
        }

        private Serveur Serveur;

        private Chef_Rang ChefRang;

        private Tables[] ListeTables;

        /// <summary>
        /// Renvoie le Serveur du rang, de type Serveur
        /// </summary>

        public Serveur GetServeur()
        {
            return this.Serveur;
        }

        /// <summary>
        /// Renvoie le Chef de Rang du Rang, de type ChefRang
        /// </summary>

        public Chef_Rang GetChefRang()
        {
            return this.ChefRang;
        }

        /// <summary>
        /// Renvoie la liste des tables du rang
        /// </summary>

        public Tables[] GetListeTables()
        {
            return this.ListeTables;
        }


    }
}
