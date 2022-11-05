namespace frm_login
{
    partial class frm_personelListele
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.rbUcret = new System.Windows.Forms.RadioButton();
            this.rbCalismaSaati = new System.Windows.Forms.RadioButton();
            this.rbAdSoyad = new System.Windows.Forms.RadioButton();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.rbTC = new System.Windows.Forms.RadioButton();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnPersonelGuncelle);
            this.panel1.Controls.Add(this.rbUcret);
            this.panel1.Controls.Add(this.rbCalismaSaati);
            this.panel1.Controls.Add(this.rbAdSoyad);
            this.panel1.Controls.Add(this.rbAlan);
            this.panel1.Controls.Add(this.rbTC);
            this.panel1.Controls.Add(this.btnPersonelSil);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 144);
            this.panel1.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.Color.Silver;
            this.lblCount.Location = new System.Drawing.Point(692, 14);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(18, 20);
            this.lblCount.TabIndex = 31;
            this.lblCount.Text = "_";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(376, 31);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 26);
            this.textBox2.TabIndex = 30;
            this.textBox2.Visible = false;
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.btnPersonelGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(939, 75);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(162, 54);
            this.btnPersonelGuncelle.TabIndex = 29;
            this.btnPersonelGuncelle.Text = "Personel Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGuncelle.Visible = false;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // rbUcret
            // 
            this.rbUcret.AutoSize = true;
            this.rbUcret.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.rbUcret.Location = new System.Drawing.Point(760, 90);
            this.rbUcret.Name = "rbUcret";
            this.rbUcret.Size = new System.Drawing.Size(118, 24);
            this.rbUcret.TabIndex = 28;
            this.rbUcret.Text = "Ücret\'e Göre";
            this.rbUcret.UseVisualStyleBackColor = true;
            // 
            // rbCalismaSaati
            // 
            this.rbCalismaSaati.AutoSize = true;
            this.rbCalismaSaati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.rbCalismaSaati.Location = new System.Drawing.Point(539, 90);
            this.rbCalismaSaati.Name = "rbCalismaSaati";
            this.rbCalismaSaati.Size = new System.Drawing.Size(189, 24);
            this.rbCalismaSaati.TabIndex = 27;
            this.rbCalismaSaati.Text = "Çalışma Saati \'ne Göre";
            this.rbCalismaSaati.UseVisualStyleBackColor = true;
            // 
            // rbAdSoyad
            // 
            this.rbAdSoyad.AutoSize = true;
            this.rbAdSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.rbAdSoyad.Location = new System.Drawing.Point(170, 90);
            this.rbAdSoyad.Name = "rbAdSoyad";
            this.rbAdSoyad.Size = new System.Drawing.Size(161, 24);
            this.rbAdSoyad.TabIndex = 26;
            this.rbAdSoyad.Text = "Ad - Soyad \'a Göre";
            this.rbAdSoyad.UseVisualStyleBackColor = true;
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.rbAlan.Location = new System.Drawing.Point(376, 90);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(111, 24);
            this.rbAlan.TabIndex = 25;
            this.rbAlan.Text = "Alan\'a Göre";
            this.rbAlan.UseVisualStyleBackColor = true;
            // 
            // rbTC
            // 
            this.rbTC.AutoSize = true;
            this.rbTC.Checked = true;
            this.rbTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.rbTC.Location = new System.Drawing.Point(30, 90);
            this.rbTC.Name = "rbTC";
            this.rbTC.Size = new System.Drawing.Size(106, 24);
            this.rbTC.TabIndex = 24;
            this.rbTC.TabStop = true;
            this.rbTC.Text = "TC\'ye Göre";
            this.rbTC.UseVisualStyleBackColor = true;
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.btnPersonelSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.White;
            this.btnPersonelSil.Location = new System.Drawing.Point(939, 75);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(162, 54);
            this.btnPersonelSil.TabIndex = 23;
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = false;
            this.btnPersonelSil.Visible = false;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(376, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = global::frm_login.Properties.Resources.turuncuCarpi;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Location = new System.Drawing.Point(1072, 14);
            this.btn_cikis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(36, 32);
            this.btn_cikis.TabIndex = 12;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1121, 343);
            this.dataGridView1.TabIndex = 1;
            // 
            // frm_personelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_personelListele";
            this.Text = "frm_personelListele";
            this.Load += new System.EventHandler(this.frm_personelListele_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.RadioButton rbUcret;
        private System.Windows.Forms.RadioButton rbCalismaSaati;
        private System.Windows.Forms.RadioButton rbAdSoyad;
        private System.Windows.Forms.RadioButton rbAlan;
        private System.Windows.Forms.RadioButton rbTC;
        public System.Windows.Forms.Button btnPersonelGuncelle;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblCount;
    }
}