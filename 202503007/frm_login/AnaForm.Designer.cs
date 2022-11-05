namespace frm_login
{
    partial class AnaForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAracIslemleri = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbAracGiris = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAracCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAracListele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPersonelIslemleri = new System.Windows.Forms.ToolStripDropDownButton();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonelGuncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonelListele = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKasa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAyarlar = new System.Windows.Forms.ToolStripDropDownButton();
            this.raporlamaSayfasınaGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbSifreDegistir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbGiriseDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAracKayitSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbPersonelKayitSil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbKasayiBosalt = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAracIslemleri,
            this.tsbAracListele,
            this.toolStripSeparator1,
            this.tsbPersonelIslemleri,
            this.tsbPersonelListele,
            this.toolStripSeparator2,
            this.tsbKasa,
            this.toolStripSeparator3,
            this.tsbAyarlar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(142, 487);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAracIslemleri
            // 
            this.tsbAracIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAracGiris,
            this.tsbAracCikis});
            this.tsbAracIslemleri.ForeColor = System.Drawing.Color.White;
            this.tsbAracIslemleri.Image = global::frm_login.Properties.Resources.AracIslemleri;
            this.tsbAracIslemleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAracIslemleri.Name = "tsbAracIslemleri";
            this.tsbAracIslemleri.Size = new System.Drawing.Size(139, 71);
            this.tsbAracIslemleri.Text = "Araç İşlemleri";
            this.tsbAracIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbAracGiris
            // 
            this.tsbAracGiris.Image = global::frm_login.Properties.Resources.aracGiris;
            this.tsbAracGiris.Name = "tsbAracGiris";
            this.tsbAracGiris.Size = new System.Drawing.Size(176, 54);
            this.tsbAracGiris.Text = "Araç Giriş";
            this.tsbAracGiris.Click += new System.EventHandler(this.tsbAracGiris_Click);
            // 
            // tsbAracCikis
            // 
            this.tsbAracCikis.Image = global::frm_login.Properties.Resources.aracCikis;
            this.tsbAracCikis.Name = "tsbAracCikis";
            this.tsbAracCikis.Size = new System.Drawing.Size(176, 54);
            this.tsbAracCikis.Text = "Araç Çıkış";
            this.tsbAracCikis.Click += new System.EventHandler(this.tsbAracCikis_Click);
            // 
            // tsbAracListele
            // 
            this.tsbAracListele.ForeColor = System.Drawing.Color.White;
            this.tsbAracListele.Image = global::frm_login.Properties.Resources.Plaka;
            this.tsbAracListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAracListele.Name = "tsbAracListele";
            this.tsbAracListele.Size = new System.Drawing.Size(139, 71);
            this.tsbAracListele.Text = "Araç Listele";
            this.tsbAracListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAracListele.Click += new System.EventHandler(this.tsbAracListele_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // tsbPersonelIslemleri
            // 
            this.tsbPersonelIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.personelSilToolStripMenuItem,
            this.tsbPersonelGuncelle});
            this.tsbPersonelIslemleri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tsbPersonelIslemleri.ForeColor = System.Drawing.Color.White;
            this.tsbPersonelIslemleri.Image = global::frm_login.Properties.Resources.Personel;
            this.tsbPersonelIslemleri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPersonelIslemleri.Name = "tsbPersonelIslemleri";
            this.tsbPersonelIslemleri.Size = new System.Drawing.Size(139, 71);
            this.tsbPersonelIslemleri.Text = "Personel İşlemleri";
            this.tsbPersonelIslemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Image = global::frm_login.Properties.Resources.personelEkleCikar;
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Image = global::frm_login.Properties.Resources.personelEkleCikar;
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.personelSilToolStripMenuItem.Text = "Personel Sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // tsbPersonelGuncelle
            // 
            this.tsbPersonelGuncelle.Image = global::frm_login.Properties.Resources.personelEkleCikar;
            this.tsbPersonelGuncelle.Name = "tsbPersonelGuncelle";
            this.tsbPersonelGuncelle.Size = new System.Drawing.Size(197, 24);
            this.tsbPersonelGuncelle.Text = "Personel Güncelle";
            this.tsbPersonelGuncelle.Click += new System.EventHandler(this.tsbPersonelGuncelle_Click);
            // 
            // tsbPersonelListele
            // 
            this.tsbPersonelListele.ForeColor = System.Drawing.Color.White;
            this.tsbPersonelListele.Image = global::frm_login.Properties.Resources.PersonelListele;
            this.tsbPersonelListele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPersonelListele.Name = "tsbPersonelListele";
            this.tsbPersonelListele.Size = new System.Drawing.Size(139, 71);
            this.tsbPersonelListele.Text = "Personel Listele";
            this.tsbPersonelListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPersonelListele.Click += new System.EventHandler(this.tsbPersonelListele_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // tsbKasa
            // 
            this.tsbKasa.ForeColor = System.Drawing.Color.White;
            this.tsbKasa.Image = global::frm_login.Properties.Resources.Kasa;
            this.tsbKasa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKasa.Name = "tsbKasa";
            this.tsbKasa.Size = new System.Drawing.Size(139, 71);
            this.tsbKasa.Text = "Kasa";
            this.tsbKasa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKasa.Click += new System.EventHandler(this.tsbKasa_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(139, 6);
            // 
            // tsbAyarlar
            // 
            this.tsbAyarlar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raporlamaSayfasınaGitToolStripMenuItem,
            this.tsbSifreDegistir,
            this.tsbGiriseDon,
            this.tsbAracKayitSil,
            this.tsbPersonelKayitSil,
            this.tsbKasayiBosalt});
            this.tsbAyarlar.ForeColor = System.Drawing.Color.White;
            this.tsbAyarlar.Image = global::frm_login.Properties.Resources.Ayarlar;
            this.tsbAyarlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAyarlar.Name = "tsbAyarlar";
            this.tsbAyarlar.Size = new System.Drawing.Size(139, 71);
            this.tsbAyarlar.Text = "Ayarlar";
            this.tsbAyarlar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // raporlamaSayfasınaGitToolStripMenuItem
            // 
            this.raporlamaSayfasınaGitToolStripMenuItem.Name = "raporlamaSayfasınaGitToolStripMenuItem";
            this.raporlamaSayfasınaGitToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.raporlamaSayfasınaGitToolStripMenuItem.Text = "Raporlama Sayfasına Git";
            this.raporlamaSayfasınaGitToolStripMenuItem.Click += new System.EventHandler(this.raporlamaSayfasınaGitToolStripMenuItem_Click);
            // 
            // tsbSifreDegistir
            // 
            this.tsbSifreDegistir.Name = "tsbSifreDegistir";
            this.tsbSifreDegistir.Size = new System.Drawing.Size(260, 24);
            this.tsbSifreDegistir.Text = "Şifre Değiştir";
            this.tsbSifreDegistir.Click += new System.EventHandler(this.tsbSifreDegistir_Click);
            // 
            // tsbGiriseDon
            // 
            this.tsbGiriseDon.Name = "tsbGiriseDon";
            this.tsbGiriseDon.Size = new System.Drawing.Size(260, 24);
            this.tsbGiriseDon.Text = "Giriş Ekranına Dön";
            this.tsbGiriseDon.Click += new System.EventHandler(this.tsbGiriseDon_Click);
            // 
            // tsbAracKayitSil
            // 
            this.tsbAracKayitSil.Name = "tsbAracKayitSil";
            this.tsbAracKayitSil.Size = new System.Drawing.Size(260, 24);
            this.tsbAracKayitSil.Text = "Tüm Araç Kayıtlarını Sil";
            this.tsbAracKayitSil.Click += new System.EventHandler(this.tsbAracKayitSil_Click);
            // 
            // tsbPersonelKayitSil
            // 
            this.tsbPersonelKayitSil.Name = "tsbPersonelKayitSil";
            this.tsbPersonelKayitSil.Size = new System.Drawing.Size(260, 24);
            this.tsbPersonelKayitSil.Text = "Tüm Personel Kayıtlarını Sil";
            this.tsbPersonelKayitSil.Click += new System.EventHandler(this.tsbPersonelKayitSil_Click);
            // 
            // tsbKasayiBosalt
            // 
            this.tsbKasayiBosalt.Name = "tsbKasayiBosalt";
            this.tsbKasayiBosalt.Size = new System.Drawing.Size(260, 24);
            this.tsbKasayiBosalt.Text = "Kasayı Kalıcı Olarak Boşalt";
            this.tsbKasayiBosalt.Click += new System.EventHandler(this.tsbKasayiBosalt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(142, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 487);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(18, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(336, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 62);
            this.label2.TabIndex = 13;
            this.label2.Text = "İSTE OTOPARK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::frm_login.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(397, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(941, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product by BarisE - V4";
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
            this.btn_cikis.TabIndex = 10;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1263, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbPersonelIslemleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbAyarlar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.ToolStripDropDownButton tsbAracIslemleri;
        private System.Windows.Forms.ToolStripMenuItem tsbAracGiris;
        private System.Windows.Forms.ToolStripMenuItem tsbAracCikis;
        private System.Windows.Forms.ToolStripButton tsbAracListele;
        private System.Windows.Forms.ToolStripButton tsbPersonelListele;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsbSifreDegistir;
        private System.Windows.Forms.ToolStripMenuItem tsbGiriseDon;
        private System.Windows.Forms.ToolStripMenuItem tsbAracKayitSil;
        private System.Windows.Forms.ToolStripMenuItem tsbPersonelKayitSil;
        private System.Windows.Forms.ToolStripButton tsbKasa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsbKasayiBosalt;
        private System.Windows.Forms.ToolStripMenuItem tsbPersonelGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem raporlamaSayfasınaGitToolStripMenuItem;
    }
}