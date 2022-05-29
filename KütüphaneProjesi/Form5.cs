using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KütüphaneProjesi
{
    public partial class Form5 : Form
    {
        baglanti bgl = new baglanti();
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form5()
        {
            InitializeComponent();
        }

        private void üyeEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeListeleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kitapListeleSilGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            this.Hide();
            frm.ShowDialog();
        }

        private void emanetKitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.ShowDialog();
        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Hide();
            frm.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkitapadi.Text != "" && txtyazari.Text != "" && txttürü.Text != "" && txtsayfasayısı.Text != "")
                {
                    string sorgu = "INSERT INTO KitapBilgileri(KitapAdı,Yazarı,Türü,SayfaSayısı,Resim)VALUES(@KitapAdı,@Yazarı,@Türü,@SayfaSayısı,@rsm)";
                    cmd = new OleDbCommand(sorgu, bgl.bagla());
                    cmd.Parameters.AddWithValue("@KitapAdı", txtkitapadi.Text);
                    cmd.Parameters.AddWithValue("@Yazarı", txtyazari.Text);
                    cmd.Parameters.AddWithValue("@Türü", txttürü.Text);
                    cmd.Parameters.AddWithValue("@SayfaSayısı", txtsayfasayısı.Text);
      
                    MessageBox.Show("Kitap Başarıyla Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtkitapadi.Clear();
                txtsayfasayısı.Clear();
                txttürü.Clear();
                txtyazari.Clear();
                txtkitapadi.Focus();
            }           
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Kitap işlemleri");       
            }

        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            this.Hide();
            frm.ShowDialog();
        }

        private void personelİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            this.Hide();
            frm.ShowDialog();
        }

        private void personelListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            this.Hide();
            frm.ShowDialog();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
