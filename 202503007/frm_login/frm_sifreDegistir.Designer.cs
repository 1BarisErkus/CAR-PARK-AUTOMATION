namespace frm_login
{
    partial class frm_sifreDegistir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbEskiSifre = new System.Windows.Forms.TextBox();
            this.txbYeniSifre = new System.Windows.Forms.TextBox();
            this.txbYeniSifreOnay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btn_cikis.TabIndex = 11;
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(389, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Eski Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label2.Location = new System.Drawing.Point(387, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yeni Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(346, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yeni Şifre Onay :";
            // 
            // txbEskiSifre
            // 
            this.txbEskiSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.txbEskiSifre.ForeColor = System.Drawing.Color.White;
            this.txbEskiSifre.Location = new System.Drawing.Point(494, 67);
            this.txbEskiSifre.Name = "txbEskiSifre";
            this.txbEskiSifre.Size = new System.Drawing.Size(171, 26);
            this.txbEskiSifre.TabIndex = 15;
            this.txbEskiSifre.TextChanged += new System.EventHandler(this.txbEskiSifre_TextChanged);
            // 
            // txbYeniSifre
            // 
            this.txbYeniSifre.BackColor = System.Drawing.Color.LightGray;
            this.txbYeniSifre.Enabled = false;
            this.txbYeniSifre.ForeColor = System.Drawing.Color.White;
            this.txbYeniSifre.Location = new System.Drawing.Point(494, 131);
            this.txbYeniSifre.Name = "txbYeniSifre";
            this.txbYeniSifre.Size = new System.Drawing.Size(171, 26);
            this.txbYeniSifre.TabIndex = 16;
            // 
            // txbYeniSifreOnay
            // 
            this.txbYeniSifreOnay.BackColor = System.Drawing.Color.LightGray;
            this.txbYeniSifreOnay.Enabled = false;
            this.txbYeniSifreOnay.ForeColor = System.Drawing.Color.White;
            this.txbYeniSifreOnay.Location = new System.Drawing.Point(494, 195);
            this.txbYeniSifreOnay.Name = "txbYeniSifreOnay";
            this.txbYeniSifreOnay.Size = new System.Drawing.Size(171, 26);
            this.txbYeniSifreOnay.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(287, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(582, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kutucukların aktifleşmesi için eski şifreyi doğru bir biçimde girmeniz gerekmekte" +
    "dir.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(122)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(494, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 67);
            this.button1.TabIndex = 19;
            this.button1.Text = "Şifre Değiştir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_sifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1121, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbYeniSifreOnay);
            this.Controls.Add(this.txbYeniSifre);
            this.Controls.Add(this.txbEskiSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_sifreDegistir";
            this.Text = "frm_sifreDegistir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbEskiSifre;
        private System.Windows.Forms.TextBox txbYeniSifre;
        private System.Windows.Forms.TextBox txbYeniSifreOnay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}