using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Master_chef_console.MODEL.RESTAURATION;

namespace Master_chef_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Maitre_Hotel M = new Maitre_Hotel();
            
            Salle_Restauration R = new Salle_Restauration();
            M.AcceuilClient();
            R.ParcoursTable(M.getNbreDeClient());
            richTextBox_trestau.Text += "Bienvenue dans notre Restaurant\n";
        }

        Salle_Restauration R = new Salle_Restauration();

        private void button_receive_Click(object sender, EventArgs e)
        {
            R.ParcoursTable(Int32.Parse(textBoxClient.Text));
            richTextBox_trestau.Text += "Le chef de rang vous conduira à la table" + R.getPos()+"\n";
            textBoxClient.Clear();
            threadAccueilChefDeRang();
            Thread.Sleep(4000);
            threadPresenterCarteResto();



        }
        public void threadAccueilChefDeRang()
        {
            Chef_Rang S = new Chef_Rang();
            Thread mainThread = Thread.CurrentThread;
            Thread thread1 = new Thread(() => S.getMoveToTable());
            richTextBox_trestau.Text += "Bonjour je suis le chef de rang, suivez moi et veuillez prendre place..\n";
            richTextBox_trestau.Clear();
            thread1.Start();
            Thread.Sleep(4000);
        }

        public void threadPresenterCarteResto()
        {
            Chef_Rang S = new Chef_Rang();
            Thread mainThread = Thread.CurrentThread;
            Thread thread1 = new Thread(() => S.getpresenterCarteResto());
            richTextBox_trestau.Text += "Les clients lisent le menu et passent leurs commandes\n";

            thread1.Start();
            Thread.Sleep(4000);
        }
        public void check()
        {
            
        }
        //////////////////winform/////////////////
        /*public String mess = "";
        public String mess_salle = "";
        public String mess_cuis = "";

        public int nb_client;
        public int reserv;
        
        private Tables Table1_2 = new Tables(2,0);
        private Tables table2_2 = new Tables(2, 1);
        private Tables table3_2 = new Tables(2, 2);
        private Tables table4_2 = new Tables(2, 3);
        private Tables table5_2 = new Tables(2, 4);
        private Tables table6_2 = new Tables(2, 5);
        private Tables table7_2 = new Tables(2, 6);
        private Tables table8_2 = new Tables(2, 7);
        private Tables table9_2 = new Tables(2, 8);
        private Tables table10_2 = new Tables(2, 9);

        private Tables table1_4 = new Tables(4, 10);
        private Tables table2_4 = new Tables(4, 11);
        private Tables table3_4 = new Tables(4, 12);
        private Tables table4_4 = new Tables(4, 13);
        private Tables table5_4 = new Tables(4, 14);
        private Tables table6_4 = new Tables(4, 15);
        private Tables table7_4 = new Tables(4, 16);
        private Tables table8_4 = new Tables(4, 17);
        private Tables table9_4 = new Tables(4, 18);
        private Tables table10_4 = new Tables(4, 19);

        private Tables table1_6 = new Tables(6, 20);
        private Tables table2_6 = new Tables(6, 21);
        private Tables table3_6 = new Tables(6, 22);
        private Tables table4_6 = new Tables(6, 23);
        private Tables table5_6 = new Tables(6, 24);
       

        private Tables table1_8 = new Tables(8, 25);
        private Tables table2_8 = new Tables(8, 26);
        private Tables table3_8 = new Tables(8, 27);
        private Tables table4_8 = new Tables(8, 28);
        private Tables table5_8 = new Tables(8, 29);

        private Tables table1_10 = new Tables(8, 25);
        private Tables table2_10 = new Tables(8, 25);

        public void open()
        {
            

        }


        public void Receive_client(int nb)
        {

            if(nb>0 & nb <= 10)
            {
               // if()


            }
            else
            {
                mess += "The restaurant can receive only 1 to 10 person per group. Please enter a available number";
            }

        }

        private void richTextBox_trestau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_welcome_Click(object sender, EventArgs e)
        {

        }

        private void button_receive_Click(object sender, EventArgs e)
        {

        }*/


    }
}
