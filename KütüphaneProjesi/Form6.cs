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
    public partial class Form6 : Form
    {
        OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kutuphaneprojesi.accdb");
        baglanti bgl = new baglanti();
        OleDbCommand komut;
        OleDbDataAdapter da;
        private void kitaplistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM KitapBilgileri", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView1.DataSource = doldur;
            bgl.bagla().Close();
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            kitaplistesi();
            label6.Text = dataGridView1.Rows.Count.ToString();
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
            Form5 frm = new Form5();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox5.Text);
                baglanti2.Open();
                string sorgusil = "DELETE FROM KitapBilgileri WHERE id=@id";
                komut = new OleDbCommand(sorgusil, baglanti2);
                komut.Parameters.AddWithValue("@id", id);
                komut.ExecuteNonQuery();
                baglanti2.Close();
                MessageBox.Show("Tebrikler Kitap Başarıyla Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kitaplistesi();
            }            
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Kitap işlemleri");
                baglanti2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtkitapadi.Text != "" && txtyazari.Text != "" && txttürü.Text != "" && txtsayfasayisi.Text != "")
                {

                    int id = int.Parse(textBox5.Text);
                    baglanti2.Open();
                    OleDbCommand komut = new OleDbCommand("update KitapBilgileri set KitapAdı='" + txtkitapadi.Text.ToString() + "',Yazarı='" + txtyazari.Text.ToString() + "',Türü='" + txttürü.Text.ToString() + "',SayfaSayısı='" + txtsayfasayisi.Text.ToString() + "' WHERE id=@id", baglanti2);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglanti2.Close();
                    MessageBox.Show("Kitap Bilgisi Başarıyla Güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kitaplistesi();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtkitapadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtyazari.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttürü.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsayfasayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtarama.Text == "")
                {
                    kitaplistesi();
                }
                else
                {
                    string sorgu = "Select * from KitapBilgileri where KitapAdı Like '%" + txtarama.Text + "%'";

                    OleDbDataAdapter adap = new OleDbDataAdapter(sorgu, bgl.bagla());

                    DataSet ds = new DataSet();

                    adap.Fill(ds, "KitapBilgileri");

                    this.dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Kitap işlemleri");
                baglanti2.Close();
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
    }
}
