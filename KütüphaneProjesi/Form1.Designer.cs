namespace KütüphaneProjesi
{
    partial class Form1
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
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.lblkullaniciadi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btngiris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.White;
            this.btngiris.Location = new System.Drawing.Point(120, 406);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(220, 46);
            this.btngiris.TabIndex = 40;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtsifre.Location = new System.Drawing.Point(120, 359);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(220, 31);
            this.txtsifre.TabIndex = 39;
            this.txtsifre.UseSystemPasswordChar = true;
            this.txtsifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsifre_KeyPress);
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblsifre.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblsifre.Location = new System.Drawing.Point(202, 333);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(70, 25);
            this.lblsifre.TabIndex = 38;
            this.lblsifre.Text = "Şifre :";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtkullaniciadi.Location = new System.Drawing.Point(120, 290);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(220, 31);
            this.txtkullaniciadi.TabIndex = 37;
            this.txtkullaniciadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtkullaniciadi_KeyPress);
            // 
            // lblkullaniciadi
            // 
            this.lblkullaniciadi.AutoSize = true;
            this.lblkullaniciadi.BackColor = System.Drawing.Color.Transparent;
            this.lblkullaniciadi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblkullaniciadi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblkullaniciadi.Location = new System.Drawing.Point(172, 264);
            this.lblkullaniciadi.Name = "lblkullaniciadi";
            this.lblkullaniciadi.Size = new System.Drawing.Size(133, 25);
            this.lblkullaniciadi.TabIndex = 36;
            this.lblkullaniciadi.Text = "Kullanıcı Adı : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KütüphaneProjesi.Properties.Resources._138_1387775_login_to_do_whatever_you_want_login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(120, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.lblkullaniciadi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label lblkullaniciadi;
    }
}

