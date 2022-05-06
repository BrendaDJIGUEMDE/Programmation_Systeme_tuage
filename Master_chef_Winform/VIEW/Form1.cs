using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        //////////////////winform/////////////////
        /*public String mess = "";
        public String mess_salle = "";
        public String mess_cuis = "";*/

        public int nb_client;
        public int reserv;
        
        private Tables table1_2 = new Tables(2,0);
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

        private Tables table1_10 = new Tables(10, 30);
        private Tables table2_10 = new Tables(10, 31);

        private Tables[] tables_restau = new Tables[32];

        private Tables[] tables_reserv = new Tables[32];

        private int id_table;

        private int click = 0;
        private int clickc = 0;

        //private Salle_Restauration salle_de_restauration = Salle_Restauration.GetInstance(tables_restau);

        public void open()
        {

            tables_restau = new Tables[32];
            tables_reserv = new Tables[32];

            tables_restau[0] = table1_2;
            tables_restau[1] = table2_2;
            tables_restau[2] = table3_2;
            tables_restau[3] = table4_2;
            tables_restau[4] = table5_2;
            tables_restau[5] = table6_2;
            tables_restau[6] = table7_2;
            tables_restau[7] = table8_2;
            tables_restau[8] = table9_2;
            tables_restau[9] = table10_2;

            tables_restau[10] = table1_4;
            tables_restau[11] = table2_4;
            tables_restau[12] = table3_4;
            tables_restau[13] = table4_4;
            tables_restau[14] = table5_4;
            tables_restau[15] = table6_4;
            tables_restau[16] = table7_4;
            tables_restau[17] = table8_4;
            tables_restau[18] = table9_4;
            tables_restau[19] = table10_4;

            tables_restau[20] = table1_6;
            tables_restau[21] = table2_6;
            tables_restau[22] = table3_6;
            tables_restau[23] = table4_6;
            tables_restau[24] = table5_6;

            tables_restau[25] = table1_8;
            tables_restau[26] = table2_8;
            tables_restau[27] = table3_8;
            tables_restau[28] = table4_8;
            tables_restau[29] = table5_8;

            tables_restau[30] = table1_10;
            tables_restau[31] = table2_10;

            tables_reserv[0] = table4_4;
            tables_reserv[1] = table9_2;
            tables_reserv[2] = table6_2;
            tables_reserv[3] = table6_2;
            tables_reserv[4] = table1_6;
            tables_reserv[5] = table2_10;
        }


        public int Receive_client(int nb)
        {
            //open();
            int id=-1;

            if (nb>0 & nb <= 10)
            {
                int i;
                int min = 32;
                
                int nc;
                int o;
                
                for (i = 0; i < 30; i++ ){
                    nc = tables_restau[i].GetNombreChaises();
                    o = tables_restau[i].Getoccuped();

                    if (nc >= nb && o==0)
                    {
                        min = Math.Min(nc, min);
                        if(min == nc)
                        {
                            int j;
                            int reserv = 0;

                            for (j = 0; j < 6; j++)
                            {
                                if (tables_reserv[j].GetId() == tables_restau[i].GetId())
                                {
                                    reserv++;
                                    
                                }
                            }  
                            if(reserv == 0)
                            {

                                id = tables_restau[i].GetId();
                                id_table = id;
                                tables_restau[i].Setoccuped(1);
                                
                            }
                        }
                    }
                }
            }
            else
            {
                richTextBox_messages.Text += "The restaurant can receive only 1 to 10 person per group. Please enter a available number\n";
            }

            return id_table;
        }

        private void richTextBox_trestau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_welcome_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_nbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_receive_Click(object sender, EventArgs e)
        {
            //richTextBox_messages.Text += "\n" + click;
            if (click == 0)
            {
                tables_restau[0] = table1_2;
                tables_restau[1] = table2_2;
                tables_restau[2] = table3_2;
                tables_restau[3] = table4_2;
                tables_restau[4] = table5_2;
                tables_restau[5] = table6_2;
                tables_restau[6] = table7_2;
                tables_restau[7] = table8_2;
                tables_restau[8] = table9_2;
                tables_restau[9] = table10_2;

                tables_restau[10] = table1_4;
                tables_restau[11] = table2_4;
                tables_restau[12] = table3_4;
                tables_restau[13] = table4_4;
                tables_restau[14] = table5_4;
                tables_restau[15] = table6_4;
                tables_restau[16] = table7_4;
                tables_restau[17] = table8_4;
                tables_restau[18] = table9_4;
                tables_restau[19] = table10_4;

                tables_restau[20] = table1_6;
                tables_restau[21] = table2_6;
                tables_restau[22] = table3_6;
                tables_restau[23] = table4_6;
                tables_restau[24] = table5_6;

                tables_restau[25] = table1_8;
                tables_restau[26] = table2_8;
                tables_restau[27] = table3_8;
                tables_restau[28] = table4_8;
                tables_restau[29] = table5_8;

                tables_restau[30] = table1_10;
                tables_restau[31] = table2_10;

                tables_reserv[0] = table4_4;
                tables_reserv[1] = table9_2;
                tables_reserv[2] = table6_2;
                tables_reserv[3] = table7_2;
                tables_reserv[4] = table1_6;
                tables_reserv[5] = table2_10;
                click++;
            }

            nb_client = Int32.Parse(comboBox_nbClient.Text);
            int i;
            int min = 11;
            int id_t=-1;
            for (i =31; i > 0; i--)
            {
               int nc = tables_restau[i].GetNombreChaises();
               int  o = tables_restau[i].Getoccuped();

                if(nb_client >= nc && o==0)
                {
                    int reserv = 0;

                    int j;
                    for (j = 0; j < 6; j++)
                    {
                        
                        if (tables_reserv[j].GetId() == tables_restau[i].GetId())
                        {
                            reserv++;
                        }
                    }

                    if(reserv == 0)
                    {
                        min = Math.Min(min, nc);
                        if (min == nc)
                        {
                                id_t = tables_restau[i].GetId();
                                
                                tables_restau[i].Setoccuped(1);   
                        }
                    }             
                }
            }

            if(id_t != -1)
            {
                richTextBox_messages.Text += "Vous etes bien enrégistrés à la table"+ id_t+"! attendez quelques instant, le chef de rang vous conduira à votre table\n";
            }
            else
            {
                richTextBox_messages.Text += "Désolé, il n'y a pas de table pour vous acuieillir\n";
            }
            

        
        }
    }

}


