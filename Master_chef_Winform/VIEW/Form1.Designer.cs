namespace Master_chef_Winform
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_reser_no = new System.Windows.Forms.RadioButton();
            this.radioButton_reserv_yes = new System.Windows.Forms.RadioButton();
            this.label_reservation = new System.Windows.Forms.Label();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.button_receive = new System.Windows.Forms.Button();
            this.label_nbclient = new System.Windows.Forms.Label();
            this.comboBox_nbClient = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox_cuisine = new System.Windows.Forms.RichTextBox();
            this.label_cuisine = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox_trestau = new System.Windows.Forms.RichTextBox();
            this.label_salleRestau = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.richTextBox_messages = new System.Windows.Forms.RichTextBox();
            this.label_messages = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton_reser_no);
            this.panel1.Controls.Add(this.radioButton_reserv_yes);
            this.panel1.Controls.Add(this.label_reservation);
            this.panel1.Controls.Add(this.label_welcome);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button_pause);
            this.panel1.Controls.Add(this.button_receive);
            this.panel1.Controls.Add(this.label_nbclient);
            this.panel1.Controls.Add(this.comboBox_nbClient);
            this.panel1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 386);
            this.panel1.TabIndex = 0;
            // 
            // radioButton_reser_no
            // 
            this.radioButton_reser_no.AutoSize = true;
            this.radioButton_reser_no.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_reser_no.Location = new System.Drawing.Point(172, 192);
            this.radioButton_reser_no.Name = "radioButton_reser_no";
            this.radioButton_reser_no.Size = new System.Drawing.Size(48, 21);
            this.radioButton_reser_no.TabIndex = 11;
            this.radioButton_reser_no.TabStop = true;
            this.radioButton_reser_no.Text = "NO";
            this.radioButton_reser_no.UseVisualStyleBackColor = true;
            // 
            // radioButton_reserv_yes
            // 
            this.radioButton_reserv_yes.AutoSize = true;
            this.radioButton_reserv_yes.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_reserv_yes.Location = new System.Drawing.Point(102, 192);
            this.radioButton_reserv_yes.Name = "radioButton_reserv_yes";
            this.radioButton_reserv_yes.Size = new System.Drawing.Size(50, 21);
            this.radioButton_reserv_yes.TabIndex = 10;
            this.radioButton_reserv_yes.TabStop = true;
            this.radioButton_reserv_yes.Text = "YES";
            this.radioButton_reserv_yes.UseVisualStyleBackColor = true;
            // 
            // label_reservation
            // 
            this.label_reservation.AutoSize = true;
            this.label_reservation.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reservation.Location = new System.Drawing.Point(12, 157);
            this.label_reservation.Name = "label_reservation";
            this.label_reservation.Size = new System.Drawing.Size(97, 18);
            this.label_reservation.TabIndex = 9;
            this.label_reservation.Text = "Reservartion :";
            // 
            // label_welcome
            // 
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.Location = new System.Drawing.Point(-4, 25);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(263, 25);
            this.label_welcome.TabIndex = 8;
            this.label_welcome.Text = "Welcome to the Master Chef!!";
            this.label_welcome.Click += new System.EventHandler(this.label_welcome_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(147, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 26);
            this.button3.TabIndex = 7;
            this.button3.Text = "Restart";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_pause
            // 
            this.button_pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_pause.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pause.Location = new System.Drawing.Point(15, 331);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(91, 29);
            this.button_pause.TabIndex = 6;
            this.button_pause.Text = "Pause";
            this.button_pause.UseVisualStyleBackColor = false;
            // 
            // button_receive
            // 
            this.button_receive.BackColor = System.Drawing.Color.Lime;
            this.button_receive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_receive.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_receive.Location = new System.Drawing.Point(81, 270);
            this.button_receive.Name = "button_receive";
            this.button_receive.Size = new System.Drawing.Size(91, 30);
            this.button_receive.TabIndex = 5;
            this.button_receive.Text = "Receive";
            this.button_receive.UseVisualStyleBackColor = false;
            this.button_receive.Click += new System.EventHandler(this.button_receive_Click);
            // 
            // label_nbclient
            // 
            this.label_nbclient.AutoSize = true;
            this.label_nbclient.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbclient.Location = new System.Drawing.Point(27, 107);
            this.label_nbclient.Name = "label_nbclient";
            this.label_nbclient.Size = new System.Drawing.Size(79, 17);
            this.label_nbclient.TabIndex = 4;
            this.label_nbclient.Text = "NB Clients :";
            // 
            // comboBox_nbClient
            // 
            this.comboBox_nbClient.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_nbClient.FormattingEnabled = true;
            this.comboBox_nbClient.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox_nbClient.Location = new System.Drawing.Point(112, 104);
            this.comboBox_nbClient.Name = "comboBox_nbClient";
            this.comboBox_nbClient.Size = new System.Drawing.Size(99, 28);
            this.comboBox_nbClient.TabIndex = 1;
            this.comboBox_nbClient.SelectedIndexChanged += new System.EventHandler(this.comboBox_nbClient_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(266, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 386);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.richTextBox_cuisine);
            this.panel4.Controls.Add(this.label_cuisine);
            this.panel4.Location = new System.Drawing.Point(3, 200);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 181);
            this.panel4.TabIndex = 1;
            // 
            // richTextBox_cuisine
            // 
            this.richTextBox_cuisine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_cuisine.Location = new System.Drawing.Point(15, 36);
            this.richTextBox_cuisine.Name = "richTextBox_cuisine";
            this.richTextBox_cuisine.Size = new System.Drawing.Size(572, 123);
            this.richTextBox_cuisine.TabIndex = 2;
            this.richTextBox_cuisine.Text = "";
            // 
            // label_cuisine
            // 
            this.label_cuisine.AutoSize = true;
            this.label_cuisine.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cuisine.Location = new System.Drawing.Point(276, 0);
            this.label_cuisine.Name = "label_cuisine";
            this.label_cuisine.Size = new System.Drawing.Size(46, 16);
            this.label_cuisine.TabIndex = 1;
            this.label_cuisine.Text = "Cuisine";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.richTextBox_trestau);
            this.panel3.Controls.Add(this.label_salleRestau);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 191);
            this.panel3.TabIndex = 0;
            // 
            // richTextBox_trestau
            // 
            this.richTextBox_trestau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_trestau.Location = new System.Drawing.Point(15, 33);
            this.richTextBox_trestau.Name = "richTextBox_trestau";
            this.richTextBox_trestau.Size = new System.Drawing.Size(572, 138);
            this.richTextBox_trestau.TabIndex = 1;
            this.richTextBox_trestau.Text = "";
            this.richTextBox_trestau.TextChanged += new System.EventHandler(this.richTextBox_trestau_TextChanged);
            // 
            // label_salleRestau
            // 
            this.label_salleRestau.AutoSize = true;
            this.label_salleRestau.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_salleRestau.Location = new System.Drawing.Point(236, 3);
            this.label_salleRestau.Name = "label_salleRestau";
            this.label_salleRestau.Size = new System.Drawing.Size(111, 16);
            this.label_salleRestau.TabIndex = 0;
            this.label_salleRestau.Text = "Salle Restauration";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.richTextBox_messages);
            this.panel5.Controls.Add(this.label_messages);
            this.panel5.Location = new System.Drawing.Point(2, 412);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(879, 120);
            this.panel5.TabIndex = 2;
            // 
            // richTextBox_messages
            // 
            this.richTextBox_messages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_messages.Location = new System.Drawing.Point(15, 19);
            this.richTextBox_messages.Name = "richTextBox_messages";
            this.richTextBox_messages.Size = new System.Drawing.Size(360, 88);
            this.richTextBox_messages.TabIndex = 3;
            this.richTextBox_messages.Text = "";
           
            // label_messages
            // 
            this.label_messages.AutoSize = true;
            this.label_messages.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messages.Location = new System.Drawing.Point(3, 0);
            this.label_messages.Name = "label_messages";
            this.label_messages.Size = new System.Drawing.Size(59, 16);
            this.label_messages.TabIndex = 1;
            this.label_messages.Text = "Messages";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 533);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.Button button_receive;
        private System.Windows.Forms.Label label_nbclient;
        private System.Windows.Forms.ComboBox comboBox_nbClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Label label_reservation;
        private System.Windows.Forms.RadioButton radioButton_reser_no;
        private System.Windows.Forms.RadioButton radioButton_reserv_yes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_cuisine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_salleRestau;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_messages;
        private System.Windows.Forms.RichTextBox richTextBox_trestau;
        private System.Windows.Forms.RichTextBox richTextBox_cuisine;
        private System.Windows.Forms.RichTextBox richTextBox_messages;
    }
}

