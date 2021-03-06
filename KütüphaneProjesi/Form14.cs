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
    public partial class Form14 : Form
    {
        OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kutuphaneprojesi.accdb");
        baglanti bgl = new baglanti();
        OleDbCommand komut;
        OleDbDataAdapter da;
        private void üyelistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM AdminGirişBilgileri", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView1.DataSource = doldur;
            bgl.bagla().Close();
        }
        public Form14()
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

        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            this.Hide();
            frm.ShowDialog();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            üyelistesi();
            label6.Text = dataGridView1.Rows.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox5.Text);
                baglanti2.Open();
                string sorgusil = "DELETE FROM AdminGirişBilgileri WHERE id=@id";
                komut = new OleDbCommand(sorgusil, baglanti2);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                MessageBox.Show("Tebrikler Üye Başarıyla Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                üyelistesi();
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "üye işlemleri");
                baglanti2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtüyeadsoyad.Text != "" && txtemail.Text != "")
                {

                    int id = int.Parse(textBox5.Text);
                    baglanti2.Open();
                    OleDbCommand komut = new OleDbCommand("update AdminGirişBilgileri set kullanıcıadı='" + txtüyeadsoyad.Text.ToString() + "',şifre='" + txtemail.Text.ToString() + "' WHERE id=@id", baglanti2);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglanti2.Close();
                    MessageBox.Show("Bilgiler Başarıyla Güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    üyelistesi();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Üye işlemleri");
                baglanti2.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtüyeadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           
            txtemail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           

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

        private void personelİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm = new Form11();
            this.Hide();
            frm.ShowDialog();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            üyelistesi();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            this.Hide();
            frm.ShowDialog();
        }

        private void personelEklemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 frm = new Form12();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
