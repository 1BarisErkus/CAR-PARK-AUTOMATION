namespace frm_login
{
    partial class frm_login
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
            this.txb_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txb_sifre = new System.Windows.Forms.TextBox();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_captcha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_cikis.BackgroundImage = global::frm_login.Properties.Resources.turuncuCarpi;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cikis.Location = new System.Drawing.Point(379, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(34, 34);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // txb_kullaniciAdi
            // 
            this.txb_kullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txb_kullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_kullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txb_kullaniciAdi.Location = new System.Drawing.Point(43, 213);
            this.txb_kullaniciAdi.Name = "txb_kullaniciAdi";
            this.txb_kullaniciAdi.Size = new System.Drawing.Size(260, 24);
            this.txb_kullaniciAdi.TabIndex = 1;
            this.txb_kullaniciAdi.Text = "Kullanıcı Adı";
            this.txb_kullaniciAdi.Enter += new System.EventHandler(this.txb_kullaniciAdi_Enter);
            this.txb_kullaniciAdi.Leave += new System.EventHandler(this.txb_kullaniciAdi_Leave);
            // 
            // txb_sifre
            // 
            this.txb_sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txb_sifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_sifre.ForeColor = System.Drawing.Color.White;
            this.txb_sifre.Location = new System.Drawing.Point(43, 298);
            this.txb_sifre.Name = "txb_sifre";
            this.txb_sifre.Size = new System.Drawing.Size(260, 24);
            this.txb_sifre.TabIndex = 2;
            this.txb_sifre.Text = "Şifre";
            this.txb_sifre.Enter += new System.EventHandler(this.txb_sifre_Enter);
            this.txb_sifre.Leave += new System.EventHandler(this.txb_sifre_Leave);
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.btn_girisyap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_girisyap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_girisyap.Location = new System.Drawing.Point(248, 359);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(152, 61);
            this.btn_girisyap.TabIndex = 3;
            this.btn_girisyap.Text = "GİRİŞ YAP";
            this.btn_girisyap.UseVisualStyleBackColor = false;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.linkLabel1.Location = new System.Drawing.Point(26, 461);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yeni Kullanıcı Oluştur / Sil";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(26, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // txb_captcha
            // 
            this.txb_captcha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txb_captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txb_captcha.ForeColor = System.Drawing.Color.White;
            this.txb_captcha.Location = new System.Drawing.Point(93, 396);
            this.txb_captcha.Name = "txb_captcha";
            this.txb_captcha.Size = new System.Drawing.Size(76, 24);
            this.txb_captcha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(58, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Captcha";
            // 
            // frm_login
            // 
            this.AcceptButton = this.btn_girisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.BackgroundImage = global::frm_login.Properties.Resources.LoginEkrani;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_captcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.txb_sifre);
            this.Controls.Add(this.txb_kullaniciAdi);
            this.Controls.Add(this.btn_cikis);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_login_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txb_sifre;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_captcha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_kullaniciAdi;
    }
}

