using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Commandes
    {
        public Commandes(Tables Table, String Plat)
        {
            this.Table = Table;
            this.Plat = Plat;
        }

        private Tables Table;

        private String Plat;

        private Boolean EnCours;

        public Tables GetTable()
        {
            return this.Table;
        }

        public string GetPlats()
        {
            return this.Plat;
        }

        /// <summary>
        /// @param Plat
        /// </summary>
        public void SetPlats(string Plat)
        {
            this.Plat = Plat;
        }

    }
}
