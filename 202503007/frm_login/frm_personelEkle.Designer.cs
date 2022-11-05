namespace frm_login
{
    partial class frm_personelEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cikis = new System.Windows.Forms.Button();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txbAdSoyad = new System.Windows.Forms.TextBox();
            this.txbTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAlan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxCalismaSaati = new System.Windows.Forms.ComboBox();
            this.txbUcret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = global::frm_login.Properties.Resources.turuncuCarpi;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Location = new System.Drawing.Point(1075, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(34, 34);
            this.btn_cikis.TabIndex = 14;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.lblAdSoyad.Location = new System.Drawing.Point(320, 57);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(95, 20);
            this.lblAdSoyad.TabIndex = 15;
            this.lblAdSoyad.Text = "Ad - Soyad :";
            // 
            // txbAdSoyad
            // 
            this.txbAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAdSoyad.ForeColor = System.Drawing.Color.White;
            this.txbAdSoyad.Location = new System.Drawing.Point(436, 55);
            this.txbAdSoyad.MaxLength = 50;
            this.txbAdSoyad.Name = "txbAdSoyad";
            this.txbAdSoyad.Size = new System.Drawing.Size(202, 26);
            this.txbAdSoyad.TabIndex = 16;
            // 
            // txbTC
            // 
            this.txbTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTC.ForeColor = System.Drawing.Color.White;
            this.txbTC.Location = new System.Drawing.Point(436, 111);
            this.txbTC.MaxLength = 11;
            this.txbTC.Name = "txbTC";
            this.txbTC.Size = new System.Drawing.Size(202, 26);
            this.txbTC.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(366, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Alan :";
            // 
            // txbAlan
            // 
            this.txbAlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbAlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAlan.ForeColor = System.Drawing.Color.White;
            this.txbAlan.Location = new System.Drawing.Point(436, 165);
            this.txbAlan.MaxLength = 50;
            this.txbAlan.Name = "txbAlan";
            this.txbAlan.Size = new System.Drawing.Size(202, 26);
            this.txbAlan.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(304, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Günlük Ücret :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(301, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Çalışma Saati :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(447, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 69);
            this.button1.TabIndex = 23;
            this.button1.Text = "Personel Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxCalismaSaati
            // 
            this.cbxCalismaSaati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.cbxCalismaSaati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCalismaSaati.ForeColor = System.Drawing.Color.White;
            this.cbxCalismaSaati.FormattingEnabled = true;
            this.cbxCalismaSaati.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCalismaSaati.Location = new System.Drawing.Point(436, 233);
            this.cbxCalismaSaati.Name = "cbxCalismaSaati";
            this.cbxCalismaSaati.Size = new System.Drawing.Size(202, 28);
            this.cbxCalismaSaati.TabIndex = 24;
            // 
            // txbUcret
            // 
            this.txbUcret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbUcret.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUcret.ForeColor = System.Drawing.Color.White;
            this.txbUcret.Location = new System.Drawing.Point(436, 316);
            this.txbUcret.MaxLength = 50;
            this.txbUcret.Name = "txbUcret";
            this.txbUcret.Size = new System.Drawing.Size(202, 26);
            this.txbUcret.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(378, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "TC :";
            // 
            // frm_personelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1121, 487);
            this.Controls.Add(this.txbUcret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCalismaSaati);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAdSoyad);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.btn_cikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_personelEkle";
            this.Text = "frm_personelEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txbAdSoyad;
        private System.Windows.Forms.TextBox txbTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAlan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxCalismaSaati;
        private System.Windows.Forms.TextBox txbUcret;
        private System.Windows.Forms.Label label4;
    }
}