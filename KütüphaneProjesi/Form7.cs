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
    public partial class Form7 : Form
    {
        OleDbConnection baglanti2 = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kutuphaneprojesi.accdb");
        baglanti bgl = new baglanti();
        OleDbCommand cmd;
        OleDbCommand komut;
        OleDbDataReader dr;
        private void emanetkitaplistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM EmanetKitap", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView1.DataSource = doldur;
            bgl.bagla().Close();
        }
        private void üyegetir()
        {
            cmd = new OleDbCommand();
            cmd.Connection = bgl.bagla();
            cmd.CommandText = "SELECT * FROM ÜyeBilgileri";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["AdSoyad"]);

            }
        }
        private void kitapgetir()
        {
            cmd = new OleDbCommand();
            cmd.Connection = bgl.bagla();
            cmd.CommandText = "SELECT * FROM KitapBilgileri";
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(dr["KitapAdı"]);

            }
        }
        public Form7()
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

        }

        private void istatistiklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm = new Form8();
            this.Hide();
            frm.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            emanetkitaplistesi();
            üyegetir();
            kitapgetir();
            label6.Text = dataGridView1.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && dateTimePicker1.Text != "")
                {
                    baglanti2.Open();
                    string sorgu = "INSERT INTO EmanetKitap(ÜyeAdıSoyadı,VerilenKitap,Tarih)VALUES(@ÜyeAdıSoyadı,@VerilenKitap,@Tarih)";
                    cmd = new OleDbCommand(sorgu, baglanti2);
                    cmd.Parameters.AddWithValue("@ÜyeAdıSoyadı", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@VerilenKitap", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Text);
                    MessageBox.Show("Emanet Kitap Kaydı Başarılı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmd.ExecuteNonQuery();
                    baglanti2.Close();
                    emanetkitaplistesi();
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

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);
            baglanti2.Open();
            string sorgusil = "DELETE FROM EmanetKitap WHERE id=@id";
            komut = new OleDbCommand(sorgusil, baglanti2);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglanti2.Close();
            MessageBox.Show("Tebrikler Emanet Kitap Başarıyla Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            emanetkitaplistesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "" && comboBox2.Text != "" && dateTimePicker1.Text != "")
                {

                    int id = int.Parse(textBox5.Text);
                    baglanti2.Open();
                    OleDbCommand komut = new OleDbCommand("update EmanetKitap set ÜyeAdıSoyadı='" + comboBox1.Text.ToString() + "',VerilenKitap='" + comboBox2.Text.ToString() + "',Tarih='" + dateTimePicker1.Text.ToString() + "' WHERE id=@id", baglanti2);
                    komut.Parameters.AddWithValue("@id", id);
                    komut.ExecuteNonQuery();
                    baglanti2.Close();
                    MessageBox.Show("Bilgiler Başarıyla Güncellenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    emanetkitaplistesi();
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Emanet Kitap işlemleri");
                baglanti2.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtarama.Text == "")
                {
                    emanetkitaplistesi();
                }
                else
                {
                    string sorgu = "Select * from EmanetKitap where ÜyeAdıSoyadı Like '%" + txtarama.Text + "%'";

                    OleDbDataAdapter adap = new OleDbDataAdapter(sorgu, bgl.bagla());

                    DataSet ds = new DataSet();

                    adap.Fill(ds, "EmanetKitap");

                    this.dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Emanet Kitap işlemleri");
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
