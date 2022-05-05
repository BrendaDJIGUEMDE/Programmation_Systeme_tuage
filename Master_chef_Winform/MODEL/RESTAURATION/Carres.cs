using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
     class Carres
    {
        public Carres(Rangs RangUn, Rangs RangDeux)
        {
            this.RangUn = RangUn;
            this.RangDeux = RangDeux;
            //initialisations par defauts
        }

        private Rangs RangUn;

        private Rangs RangDeux;

        


        /// <summary>
        /// Renvoie l'attribut RangUn de type Rang
        /// </summary>

        public Rangs GetRangUn()
        {
            return this.RangUn;
        }

        /// <summary>
        /// Renvoie l'attribut RangDeux de type Rang
        /// </summary>

        public Rangs GetRangDeux()
        {
            return this.RangDeux;
        }
    }
}
