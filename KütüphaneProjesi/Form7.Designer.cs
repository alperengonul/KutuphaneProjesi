namespace Kutuphaneprojesi
{
    partial class Form7
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
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblverilenkitap = new System.Windows.Forms.Label();
            this.lbluyeadisoyadi = new System.Windows.Forms.Label();
            this.lblnot = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnemanetkitapkaydet = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblarama = new System.Windows.Forms.Label();
            this.txtarama = new System.Windows.Forms.TextBox();
            this.personelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 4;
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
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListelemeToolStripMenuItem,
            this.personelEklemeToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // personelListelemeToolStripMenuItem
            // 
            this.personelListelemeToolStripMenuItem.Name = "personelListelemeToolStripMenuItem";
            this.personelListelemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelListelemeToolStripMenuItem.Text = "Personel Listeleme";
            this.personelListelemeToolStripMenuItem.Click += new System.EventHandler(this.personelListelemeToolStripMenuItem_Click);
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
            this.dataGridView1.Size = new System.Drawing.Size(444, 392);
            this.dataGridView1.TabIndex = 141;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.BackColor = System.Drawing.Color.Transparent;
            this.lbltarih.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbltarih.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbltarih.Location = new System.Drawing.Point(105, 216);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(70, 25);
            this.lbltarih.TabIndex = 173;
            this.lbltarih.Text = "Tarih :";
            // 
            // lblverilenkitap
            // 
            this.lblverilenkitap.AutoSize = true;
            this.lblverilenkitap.BackColor = System.Drawing.Color.Transparent;
            this.lblverilenkitap.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblverilenkitap.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblverilenkitap.Location = new System.Drawing.Point(76, 148);
            this.lblverilenkitap.Name = "lblverilenkitap";
            this.lblverilenkitap.Size = new System.Drawing.Size(132, 25);
            this.lblverilenkitap.TabIndex = 171;
            this.lblverilenkitap.Text = "Verilen Kitap :";
            // 
            // lbluyeadisoyadi
            // 
            this.lbluyeadisoyadi.AutoSize = true;
            this.lbluyeadisoyadi.BackColor = System.Drawing.Color.Transparent;
            this.lbluyeadisoyadi.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.lbluyeadisoyadi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbluyeadisoyadi.Location = new System.Drawing.Point(69, 84);
            this.lbluyeadisoyadi.Name = "lbluyeadisoyadi";
            this.lbluyeadisoyadi.Size = new System.Drawing.Size(153, 25);
            this.lbluyeadisoyadi.TabIndex = 169;
            this.lbluyeadisoyadi.Text = "Üye Adı Soyadı :";
            // 
            // lblnot
            // 
            this.lblnot.AutoSize = true;
            this.lblnot.BackColor = System.Drawing.Color.Transparent;
            this.lblnot.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Bold);
            this.lblnot.ForeColor = System.Drawing.Color.Black;
            this.lblnot.Location = new System.Drawing.Point(36, 471);
            this.lblnot.Name = "lblnot";
            this.lblnot.Size = new System.Drawing.Size(252, 28);
            this.lblnot.TabIndex = 177;
            this.lblnot.Text = "Not: Emanet Kitap silmek için listeden bir\r\nkayıt seçip üye sil butonuna basınız";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Red;
            this.btnsil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.ForeColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(39, 360);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(204, 46);
            this.btnsil.TabIndex = 176;
            this.btnsil.Text = "Emanet Kitap Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnemanetkitapkaydet
            // 
            this.btnemanetkitapkaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnemanetkitapkaydet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnemanetkitapkaydet.ForeColor = System.Drawing.Color.Black;
            this.btnemanetkitapkaydet.Location = new System.Drawing.Point(39, 308);
            this.btnemanetkitapkaydet.Name = "btnemanetkitapkaydet";
            this.btnemanetkitapkaydet.Size = new System.Drawing.Size(204, 46);
            this.btnemanetkitapkaydet.TabIndex = 175;
            this.btnemanetkitapkaydet.Text = "Emanet Kitap Kaydet";
            this.btnemanetkitapkaydet.UseVisualStyleBackColor = false;
            this.btnemanetkitapkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Green;
            this.btnguncelle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncelle.ForeColor = System.Drawing.Color.White;
            this.btnguncelle.Location = new System.Drawing.Point(42, 412);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(204, 46);
            this.btnguncelle.TabIndex = 178;
            this.btnguncelle.Text = "Emanet Kitap Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 31);
            this.comboBox1.TabIndex = 180;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(207, 31);
            this.comboBox2.TabIndex = 181;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(39, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 31);
            this.dateTimePicker1.TabIndex = 182;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.textBox5.Location = new System.Drawing.Point(23, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(10, 31);
            this.textBox5.TabIndex = 183;
            this.textBox5.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label10.Location = new System.Drawing.Point(562, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 25);
            this.label10.TabIndex = 186;
            this.label10.Text = "Kayıt Bulunmaktadır.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(472, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 185;
            this.label4.Text = "Toplam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(539, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 184;
            // 
            // lblarama
            // 
            this.lblarama.AutoSize = true;
            this.lblarama.BackColor = System.Drawing.Color.Transparent;
            this.lblarama.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblarama.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblarama.Location = new System.Drawing.Point(409, 56);
            this.lblarama.Name = "lblarama";
            this.lblarama.Size = new System.Drawing.Size(225, 19);
            this.lblarama.TabIndex = 188;
            this.lblarama.Text = "Üye Ad Soyada Göre Kayıt Ara";
            // 
            // txtarama
            // 
            this.txtarama.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtarama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(87)))), ((int)(((byte)(71)))));
            this.txtarama.Location = new System.Drawing.Point(413, 78);
            this.txtarama.Name = "txtarama";
            this.txtarama.Size = new System.Drawing.Size(204, 31);
            this.txtarama.TabIndex = 187;
            this.txtarama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // personelEklemeToolStripMenuItem
            // 
            this.personelEklemeToolStripMenuItem.Name = "personelEklemeToolStripMenuItem";
            this.personelEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelEklemeToolStripMenuItem.Text = "Personel Ekleme";
            this.personelEklemeToolStripMenuItem.Click += new System.EventHandler(this.personelEklemeToolStripMenuItem_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.lblarama);
            this.Controls.Add(this.txtarama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.lblnot);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnemanetkitapkaydet);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lblverilenkitap);
            this.Controls.Add(this.lbluyeadisoyadi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap İşlemleri";
            this.Load += new System.EventHandler(this.Form7_Load);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.Label lblverilenkitap;
        private System.Windows.Forms.Label lbluyeadisoyadi;
        private System.Windows.Forms.Label lblnot;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnemanetkitapkaydet;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblarama;
        private System.Windows.Forms.TextBox txtarama;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeToolStripMenuItem;
    }
}