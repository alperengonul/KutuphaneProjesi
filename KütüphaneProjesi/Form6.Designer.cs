namespace KütüphaneProjesi
{
    partial class Form6
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
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblnot = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtsayfasayisi = new System.Windows.Forms.TextBox();
            this.lblsayfasayisi = new System.Windows.Forms.Label();
            this.txttürü = new System.Windows.Forms.TextBox();
            this.lblturu = new System.Windows.Forms.Label();
            this.txtyazari = new System.Windows.Forms.TextBox();
            this.lblyazari = new System.Windows.Forms.Label();
            this.txtkitapadi = new System.Windows.Forms.TextBox();
            this.lblkitapadi = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblarama = new System.Windows.Forms.Label();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.üyeİşlemleriToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.emanetKitapİşlemleriToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
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
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.BackColor = System.Drawing.Color.Transparent;
            this.lblnot.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Bold);
            this.lblnot.ForeColor = System.Drawing.Color.Black;
            this.lblnot.Location = new System.Drawing.Point(48, 454);
            this.lblnot.Name = "lblnot";
            this.lblnot.Size = new System.Drawing.Size(214, 28);
            this.lblnot.TabIndex = 132;
            this.lblnot.Text = "Not: Kitap silmek için listeden bir\r\nkayıt seçip üye sil butonuna basınız";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(51, 396);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(204, 46);
            this.btnsil.TabIndex = 131;
            this.btnsil.Text = "Kitap Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Green;
            this.btnguncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.White;
            this.btnguncelle.Location = new System.Drawing.Point(51, 344);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(204, 46);
            this.btnguncelle.TabIndex = 130;
            this.btnguncelle.Text = "Kitap Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(489, 367);
            this.dataGridView1.TabIndex = 117;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // txtsayfasayisi
            // 
            this.txtsayfasayisi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsayfasayisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtsayfasayisi.Location = new System.Drawing.Point(51, 307);
            this.txtsayfasayisi.Name = "txtsayfasayisi";
            this.txtsayfasayisi.Size = new System.Drawing.Size(207, 31);
            this.txtsayfasayisi.TabIndex = 140;
            // 
            // lblsayfasayisi
            // 
            this.lblsayfasayisi.AutoSize = true;
            this.lblsayfasayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblsayfasayisi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblsayfasayisi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblsayfasayisi.Location = new System.Drawing.Point(82, 280);
            this.lblsayfasayisi.Name = "lblsayfasayisi";
            this.lblsayfasayisi.Size = new System.Drawing.Size(129, 25);
            this.lblsayfasayisi.TabIndex = 139;
            this.lblsayfasayisi.Text = "Sayfa Sayısı :";
            // 
            // txttürü
            // 
            this.txttürü.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txttürü.Location = new System.Drawing.Point(51, 243);
            this.txttürü.Name = "txttürü";
            this.txttürü.Size = new System.Drawing.Size(207, 31);
            this.txttürü.TabIndex = 138;
            // 
            // lblturu
            // 
            this.lblturu.AutoSize = true;
            this.lblturu.BackColor = System.Drawing.Color.Transparent;
            this.lblturu.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblturu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblturu.Location = new System.Drawing.Point(113, 216);
            this.lblturu.Name = "lblturu";
            this.lblturu.Size = new System.Drawing.Size(64, 25);
            this.lblturu.TabIndex = 137;
            this.lblturu.Text = "Türü :";
            // 
            // txtyazari
            // 
            this.txtyazari.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyazari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtyazari.Location = new System.Drawing.Point(51, 179);
            this.txtyazari.Name = "txtyazari";
            this.txtyazari.Size = new System.Drawing.Size(207, 31);
            this.txtyazari.TabIndex = 136;
            // 
            // lblyazari
            // 
            this.lblyazari.AutoSize = true;
            this.lblyazari.BackColor = System.Drawing.Color.Transparent;
            this.lblyazari.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblyazari.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblyazari.Location = new System.Drawing.Point(110, 151);
            this.lblyazari.Name = "lblyazari";
            this.lblyazari.Size = new System.Drawing.Size(77, 25);
            this.lblyazari.TabIndex = 135;
            this.lblyazari.Text = "Yazarı :";
            // 
            // txtkitapadi
            // 
            this.txtkitapadi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkitapadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtkitapadi.Location = new System.Drawing.Point(51, 115);
            this.txtkitapadi.Name = "txtkitapadi";
            this.txtkitapadi.Size = new System.Drawing.Size(207, 31);
            this.txtkitapadi.TabIndex = 134;
            // 
            // lblkitapadi
            // 
            this.lblkitapadi.AutoSize = true;
            this.lblkitapadi.BackColor = System.Drawing.Color.Transparent;
            this.lblkitapadi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblkitapadi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblkitapadi.Location = new System.Drawing.Point(100, 87);
            this.lblkitapadi.Name = "lblkitapadi";
            this.lblkitapadi.Size = new System.Drawing.Size(101, 25);
            this.lblkitapadi.TabIndex = 133;
            this.lblkitapadi.Text = "Kitap Adı :";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.textBox5.Location = new System.Drawing.Point(35, 115);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(10, 31);
            this.textBox5.TabIndex = 141;
            this.textBox5.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(607, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 144;
            this.label10.Text = "Kayıt Bulunmaktadır.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(510, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 143;
            this.label7.Text = "Toplam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(577, 486);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 142;
            // 
            // lblarama
            // 
            this.lblarama.AutoSize = true;
            this.lblarama.BackColor = System.Drawing.Color.Transparent;
            this.lblarama.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblarama.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblarama.Location = new System.Drawing.Point(447, 46);
            this.lblarama.Name = "lblarama";
            this.lblarama.Size = new System.Drawing.Size(198, 19);
            this.lblarama.TabIndex = 146;
            this.lblarama.Text = "Kitap Adına Göre Kayıt Ara";
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtarama.Location = new System.Drawing.Point(441, 68);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(204, 31);
            this.txtarama.TabIndex = 145;
            this.txtarama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.lblarama);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtsayfasayisi);
            this.Controls.Add(this.lblsayfasayisi);
            this.Controls.Add(this.txttürü);
            this.Controls.Add(this.lblturu);
            this.Controls.Add(this.txtyazari);
            this.Controls.Add(this.lblyazari);
            this.Controls.Add(this.txtkitapadi);
            this.Controls.Add(this.lblkitapadi);
            this.Controls.Add(this.lblnot);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblnot;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtsayfasayisi;
        private System.Windows.Forms.Label lblsayfasayisi;
        private System.Windows.Forms.TextBox txttürü;
        private System.Windows.Forms.Label lblturu;
        private System.Windows.Forms.TextBox txtyazari;
        private System.Windows.Forms.Label lblyazari;
        private System.Windows.Forms.TextBox txtkitapadi;
        private System.Windows.Forms.Label lblkitapadi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblarama;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
    }
}