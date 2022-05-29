namespace KütüphaneProjesi
{
    partial class Form5
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.btnkitapekle = new System.Windows.Forms.Button();
            this.txtsayfasayısı = new System.Windows.Forms.TextBox();
            this.lblsayfasayisi = new System.Windows.Forms.Label();
            this.txttürü = new System.Windows.Forms.TextBox();
            this.lbltürü = new System.Windows.Forms.Label();
            this.txtyazari = new System.Windows.Forms.TextBox();
            this.lblyazari = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.lblkitapadi = new System.Windows.Forms.Label();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.emanetKitapİşlemleriToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            this.üyeİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeİşlemleriToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            this.kitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kitapİşlemleriToolStripMenuItem_Click);
            // 
            // emanetKitapİşlemleriToolStripMenuItem
            // 
            this.emanetKitapİşlemleriToolStripMenuItem.Name = "emanetKitapİşlemleriToolStripMenuItem";
            this.emanetKitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.emanetKitapİşlemleriToolStripMenuItem.Text = "Emanet Kitap İşlemleri";
            this.emanetKitapİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.emanetKitapİşlemleriToolStripMenuItem_Click);
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            this.istatistiklerToolStripMenuItem.Click += new System.EventHandler(this.istatistiklerToolStripMenuItem_Click);
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.BackColor = System.Drawing.Color.Transparent;
            this.lblbaslik.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblbaslik.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblbaslik.Location = new System.Drawing.Point(146, 47);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(223, 25);
            this.lblbaslik.TabIndex = 111;
            this.lblbaslik.Text = "KİTAP EKLEME SAYFASI";
            // 
            // btnkitapekle
            // 
            this.btnkitapekle.BackColor = System.Drawing.Color.Green;
            this.btnkitapekle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkitapekle.ForeColor = System.Drawing.Color.White;
            this.btnkitapekle.Location = new System.Drawing.Point(151, 366);
            this.btnkitapekle.Name = "btnkitapekle";
            this.btnkitapekle.Size = new System.Drawing.Size(207, 46);
            this.btnkitapekle.TabIndex = 110;
            this.btnkitapekle.Text = "Kitap Ekle";
            this.btnkitapekle.UseVisualStyleBackColor = false;
            this.btnkitapekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsayfasayısı
            // 
            this.txtsayfasayısı.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayfasayısı.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtsayfasayısı.Location = new System.Drawing.Point(151, 316);
            this.txtsayfasayısı.Name = "txtsayfasayısı";
            this.txtsayfasayısı.Size = new System.Drawing.Size(207, 31);
            this.txtsayfasayısı.TabIndex = 109;
            // 
            // lblsayfasayisi
            // 
            this.lblsayfasayisi.AutoSize = true;
            this.lblsayfasayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblsayfasayisi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblsayfasayisi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblsayfasayisi.Location = new System.Drawing.Point(182, 289);
            this.lblsayfasayisi.Name = "lblsayfasayisi";
            this.lblsayfasayisi.Size = new System.Drawing.Size(129, 25);
            this.lblsayfasayisi.TabIndex = 108;
            this.lblsayfasayisi.Text = "Sayfa Sayısı :";
            // 
            // txttürü
            // 
            this.txttürü.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txttürü.Location = new System.Drawing.Point(151, 252);
            this.txttürü.Name = "txttürü";
            this.txttürü.Size = new System.Drawing.Size(207, 31);
            this.txttürü.TabIndex = 107;
            // 
            // lbltürü
            // 
            this.lbltürü.AutoSize = true;
            this.lbltürü.BackColor = System.Drawing.Color.Transparent;
            this.lbltürü.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbltürü.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbltürü.Location = new System.Drawing.Point(213, 225);
            this.lbltürü.Name = "lbltürü";
            this.lbltürü.Size = new System.Drawing.Size(64, 25);
            this.lbltürü.TabIndex = 106;
            this.lbltürü.Text = "Türü :";
            // 
            // txtyazari
            // 
            this.txtyazari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtyazari.Location = new System.Drawing.Point(151, 188);
            this.txtyazari.Name = "txtyazari";
            this.txtyazari.Size = new System.Drawing.Size(207, 31);
            this.txtyazari.TabIndex = 105;
            // 
            // lblyazari
            // 
            this.lblyazari.AutoSize = true;
            this.lblyazari.BackColor = System.Drawing.Color.Transparent;
            this.lblyazari.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblyazari.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblyazari.Location = new System.Drawing.Point(210, 160);
            this.lblyazari.Name = "lblyazari";
            this.lblyazari.Size = new System.Drawing.Size(77, 25);
            this.lblyazari.TabIndex = 104;
            this.lblyazari.Text = "Yazarı :";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkitapadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtkitapadi.Location = new System.Drawing.Point(151, 124);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(207, 31);
            this.txtkitapadi.TabIndex = 103;
            // 
            // lblkitapadi
            // 
            this.lblkitapadi.AutoSize = true;
            this.lblkitapadi.BackColor = System.Drawing.Color.Transparent;
            this.lblkitapadi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblkitapadi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblkitapadi.Location = new System.Drawing.Point(200, 96);
            this.lblkitapadi.Name = "lblkitapadi";
            this.lblkitapadi.Size = new System.Drawing.Size(101, 25);
            this.lblkitapadi.TabIndex = 102;
            this.lblkitapadi.Text = "Kitap Adı :";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 445);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.btnkitapekle);
            this.Controls.Add(this.txtsayfasayısı);
            this.Controls.Add(this.lblsayfasayisi);
            this.Controls.Add(this.txttürü);
            this.Controls.Add(this.lbltürü);
            this.Controls.Add(this.txtyazari);
            this.Controls.Add(this.lblyazari);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.lblkitapadi);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekleme";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.Button btnkitapekle;
        private System.Windows.Forms.TextBox txtsayfasayısı;
        private System.Windows.Forms.Label lblsayfasayisi;
        private System.Windows.Forms.TextBox txttürü;
        private System.Windows.Forms.Label lbltürü;
        private System.Windows.Forms.TextBox txtyazari;
        private System.Windows.Forms.Label lblyazari;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label lblkitapadi;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}