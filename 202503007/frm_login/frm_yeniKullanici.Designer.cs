namespace frm_login
{
    partial class frm_yeniKullanici
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txbSifre = new System.Windows.Forms.TextBox();
            this.txbSifreOnay = new System.Windows.Forms.TextBox();
            this.cbxRobot = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.cbxGorunurluk = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txbYetki = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Kullanıcı Oluşturma\r\nPaneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(99, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(58, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre Onay :";
            // 
            // txbKullaniciAdi
            // 
            this.txbKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txbKullaniciAdi.Location = new System.Drawing.Point(168, 146);
            this.txbKullaniciAdi.Name = "txbKullaniciAdi";
            this.txbKullaniciAdi.Size = new System.Drawing.Size(174, 26);
            this.txbKullaniciAdi.TabIndex = 4;
            // 
            // txbSifre
            // 
            this.txbSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbSifre.ForeColor = System.Drawing.Color.White;
            this.txbSifre.Location = new System.Drawing.Point(168, 213);
            this.txbSifre.Name = "txbSifre";
            this.txbSifre.PasswordChar = '*';
            this.txbSifre.Size = new System.Drawing.Size(174, 26);
            this.txbSifre.TabIndex = 5;
            // 
            // txbSifreOnay
            // 
            this.txbSifreOnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbSifreOnay.ForeColor = System.Drawing.Color.White;
            this.txbSifreOnay.Location = new System.Drawing.Point(168, 280);
            this.txbSifreOnay.Name = "txbSifreOnay";
            this.txbSifreOnay.PasswordChar = '*';
            this.txbSifreOnay.Size = new System.Drawing.Size(174, 26);
            this.txbSifreOnay.TabIndex = 6;
            // 
            // cbxRobot
            // 
            this.cbxRobot.AutoSize = true;
            this.cbxRobot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.cbxRobot.Location = new System.Drawing.Point(12, 450);
            this.cbxRobot.Name = "cbxRobot";
            this.cbxRobot.Size = new System.Drawing.Size(233, 24);
            this.cbxRobot.TabIndex = 7;
            this.cbxRobot.Text = "Robot olmadığınızı doğrulayın";
            this.cbxRobot.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(261, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 54);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kullanıcı Oluştur";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = global::frm_login.Properties.Resources.turuncuCarpi;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Location = new System.Drawing.Point(388, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(34, 34);
            this.btn_cikis.TabIndex = 9;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // cbxGorunurluk
            // 
            this.cbxGorunurluk.AutoSize = true;
            this.cbxGorunurluk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.cbxGorunurluk.Location = new System.Drawing.Point(233, 328);
            this.cbxGorunurluk.Name = "cbxGorunurluk";
            this.cbxGorunurluk.Size = new System.Drawing.Size(189, 24);
            this.cbxGorunurluk.TabIndex = 10;
            this.cbxGorunurluk.Text = "Şifre görünürlüğünü aç";
            this.cbxGorunurluk.UseVisualStyleBackColor = true;
            this.cbxGorunurluk.CheckedChanged += new System.EventHandler(this.cbxGorunurluk_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(261, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Kullanıcı Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbYetki
            // 
            this.txbYetki.Location = new System.Drawing.Point(12, 395);
            this.txbYetki.Name = "txbYetki";
            this.txbYetki.Size = new System.Drawing.Size(233, 26);
            this.txbYetki.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yetki Şifresini Giriniz :";
            // 
            // frm_yeniKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbYetki);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbxGorunurluk);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxRobot);
            this.Controls.Add(this.txbSifreOnay);
            this.Controls.Add(this.txbSifre);
            this.Controls.Add(this.txbKullaniciAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_yeniKullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_yeniKullanici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbKullaniciAdi;
        private System.Windows.Forms.TextBox txbSifre;
        private System.Windows.Forms.TextBox txbSifreOnay;
        private System.Windows.Forms.CheckBox cbxRobot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.CheckBox cbxGorunurluk;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbYetki;
        private System.Windows.Forms.Label label5;
    }
}