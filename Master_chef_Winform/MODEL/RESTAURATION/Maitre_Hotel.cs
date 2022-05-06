using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Master_chef_console.MODEL.RESTAURATION
{
    internal class Maitre_Hotel
    {

        public void AcceuilClient()
        {
            Console.WriteLine("****************Bienvenue dans notre Restaurant*********** \n");
            Console.WriteLine(" ****** Combien etes vous ? ****** \n");
            Check();


            Console.WriteLine("Veuillez patienter le chef de rang..");


        }

        String Acceuil = "****************Bienvenue dans notre Restaurant***********\n" +
                         "**************** Combien etes vous ? *********************\n";

        public string getAcceuil()
        {
            return Acceuil;
        }

        public void AccueilClient2()
        {

        }
        int nbreClientInt=0 ;
        public void Check()
        {


            /* do
             {
                 try
                 {

                     nbreClientInt = Int32.Parse(Console.ReadLine());

                 }
                 catch (Exception)
                 {
                     Console.WriteLine("Veuilez ecrire un nombre");
                     Thread.Sleep(5000);
                     Console.Clear();
                     AcceuilClient();
                 }
             }
             while (nbreClientInt >= 4 && nbreClientInt <= 10);

             return nbreClientInt;

            nbreClientInt = Int32.Parse(Console.ReadLine());
            if (nbreClientInt < 4 || nbreClientInt > 10)
            {
                Console.WriteLine("Veuilez ecrire un nombre");
                Thread.Sleep(3000);
                Console.Clear();
                AcceuilClient();
            }
            */

            




        }

        public int getNbreDeClient()
        {
            return nbreClientInt;
        }
    }
}
