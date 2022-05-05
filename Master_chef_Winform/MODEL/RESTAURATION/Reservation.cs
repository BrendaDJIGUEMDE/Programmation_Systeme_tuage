using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Reservation
    {
       // Class.Strategy _GetterSetter_Reservation;

        public Reservation(Boolean Reserved, Tables Table, Boolean Matin)
        {
            this.Reserved = Reserved;
            this.Table = Table;
            this.Matin = Matin;
            Date = DateTime.Now;
        }

        private Boolean Reserved;

        private Tables Table;
        //L'objet Reservation compose une Table, on l'accede par cette table

        //True = Service du Midi
        //false = Service du soir

        private Boolean Matin;

        private DateTime Date;

        /// <summary>
        /// Renvoie 
        /// </summary>

        public Boolean GetReserved()
        {
            return this.Reserved;
        }

        /// <summary>
        /// @param boolean
        /// Change l'etat de la reservation
        /// Check si la table est deja reserve / Change son état egalement
        /// </summary>

        public void SetReserved(Boolean State)
        {
            this.Reserved = State;
        }

        /// <summary>
        /// 
        /// </summary>

        public Tables GetTable()
        {
            //Table Table
            return this.Table;
        }

        /// <summary>
        /// @param Table
        /// </summary>
        public void SetTable(Tables Table)
        {
            this.Table = Table;
        }

        /// <summary>
        /// 
        /// </summary>

        public Boolean GetMatin()
        {
            return this.Matin;
        }

        /// <summary>
        /// @param boolean
        /// </summary>

        public void SetMatin(Boolean State)
        {
            this.Matin = State;
        }

        /// <summary>
        /// QUELLE EST LUTILITE DE CETTE METODE ??
        /// </summary>
        /*  
          public DateTime GetDate() {
              return this.Date;
          }*/

    }
}
