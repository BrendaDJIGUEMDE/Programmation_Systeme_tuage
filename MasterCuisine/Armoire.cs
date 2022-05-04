using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCuisine
{
    internal class Armoire
    {
        private int Assiettes = 150;

        private int Couverts = 150;

        private int Verres = 150;

        private int JeuCafe = 50;

        private int Serviettes = 150;

        private int Napes = 40;

        private static Armoire Instance;


        /// <summary>
        /// Private constructor of the Singleton without args
        /// </summary>
        private Armoire()
        {
            this.Assiettes = 0;
            this.Couverts = 0;
            this.Verres = 0;
            this.JeuCafe = 0;
            this.Serviettes = 0;
            this.Napes = 0;
        }

        /// <summary>
        /// Private constructor of the Singleton without args
        /// </summary>
        private Armoire(int assiettes, int couverts, int verres, int jeuCafe, int serviettes, int napes)
        {
            this.Assiettes = assiettes;
            this.Couverts = couverts;
            this.Verres = verres;
            this.JeuCafe = jeuCafe;
            this.Serviettes = serviettes;
            this.Napes = napes;
        }

        /// <summary>
        /// Return the number of plates
        /// </summary>
        public int GetAssiettes()
        {
            return this.Assiettes;
        }

        /// <summary>
        /// Set the number of plates
        /// @param int
        /// </summary>
        public void SetAssiettes(int nb)
        {
            this.Assiettes += nb;
        }

        /// <summary>
        /// Return the number of Couverts
        /// </summary>
        public int GetCouverts()
        {
            return this.Couverts;
        }

        /// <summary>
        /// Update the number of Couverts
        /// @param int
        /// </summary>
        public void SetCouverts(int nb)
        {
            this.Couverts += nb;
        }

        /// <summary>
        /// Det the number of glasses
        /// </summary>
        public int GetVerres()
        {
            return this.Verres;
        }

        /// <summary>
        /// Update the number of glasses
        /// @param int
        /// </summary>
        public void SetVerres(int nb)
        {
            this.Verres += nb;
        }


        /// <summary>
        /// Return the number of cofe sets
        /// </summary>
        public int GetJeuCafe()
        {
            return this.JeuCafe;
        }

        /// <summary>
        /// Update the number of cofe sets
        /// @param int
        /// </summary>
        public void SetJeuCafe(int nb)
        {
            this.JeuCafe += nb;
        }

        /// <summary>
        /// Return the number of towels
        /// </summary>
        public int GetServiettes()
        {
            return this.Serviettes;
        }

        /// <summary>
        /// Update the number of towels
        /// @param int
        /// </summary>
        public void SetServiettes(int nb)
        {
            this.Serviettes += nb;
        }

        /// <summary>
        /// Return the number of tablecloth
        /// </summary>
        public int GetNapes()
        {
            return this.Napes;
        }

        /// <summary>
        /// Update the nulber of table cloth
        /// @param int
        /// </summary>
        public void SetNapes(int nb)
        {
            this.Napes += nb;
        }

        /// <summary>
        /// Creation and return of the singleton without args
        /// </summary>
        public static Armoire GetInstance()
        {
            if (Instance is null)
            {
                Instance = new Armoire();
            }
            return Instance;
        }

        /// <summary>
        /// Creation and return of the singleton with args
        /// </summary>
        public static Armoire GetInstance(int assiettes, int couverts, int verres, int jeuCafe, int serviettes, int napes)
        {
            if (Instance is null)
            {
                Instance = new Armoire(assiettes, couverts, verres, jeuCafe, serviettes, napes);
            }
            return Instance;
        }
    }
}
