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

namespace Kutuphaneprojesi
{
    public partial class Form3 : Form
    {
        baglanti bgl = new baglanti();
        OleDbCommand cmd;
        public Form3()
        {
            InitializeComponent();
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

        private void kitapİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            this.Hide();
            frm.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            this.Hide();
            frm.ShowDialog();
        }

        private void üyeEklemeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtüyeadsoyad.Text != "" && txttc.Text != "" && txttel.Text != "" && txtemail.Text != "" && txtyaş.Text != "" && txtadres.Text != "")
                {
                    string sorgu = "INSERT INTO ÜyeBilgileri(AdSoyad,TcNo,TelefonNumarası,Email,Yaş,Adres,Cinsiyet)VALUES(@AdSoyad,@TcNo,@TelefonNumarası,@Email,@Yaş,@Adres,@Cinsiyet)";
                    cmd = new OleDbCommand(sorgu, bgl.bagla());
                    cmd.Parameters.AddWithValue("@AdSoyad", txtüyeadsoyad.Text);
                    cmd.Parameters.AddWithValue("@TcNo", txttc.Text);
                    cmd.Parameters.AddWithValue("@TelefonNumarası", txttel.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@Yaş", txtyaş.Text);
                    cmd.Parameters.AddWithValue("@Adres", txtadres.Text);
                    cmd.Parameters.AddWithValue("@Cinsiyet", cmbcinsiyet.Text);
                    MessageBox.Show("Üye Başarıyla Eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                    txtüyeadsoyad.Clear();
                    txttc.Clear();
                    txttel.Clear();
                    txtemail.Clear();
                    txtyaş.Clear();
                    txtadres.Clear();
                    txtüyeadsoyad.Focus();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Üye işlemleri");

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbcinsiyet.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txttc.MaxLength = 11;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            txttel.MaxLength = 11;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void üyeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            this.Hide();
            frm.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
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
