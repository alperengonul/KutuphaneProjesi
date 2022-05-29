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
    public partial class Form1 : Form
    {
        baglanti bgl = new baglanti();
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtkullaniciadi.Text != "" && txtsifre.Text != "")
                {
                    string sorgu = "SELECT * FROM AdminGirişBilgileri where kullanıcıadı=@kullanıcıadı AND şifre=@şifre";
                    cmd = new OleDbCommand(sorgu, bgl.bagla());
                    cmd.Parameters.AddWithValue("@kullanıcıadı", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@şifre", txtsifre.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Hatalı Bilgi. Tekrar Deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Giriş işlemleri");          
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtsifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtkullaniciadi.Text != "" && txtsifre.Text != "")
                {
                    string sorgu = "SELECT * FROM AdminGirişBilgileri where kullanıcıadı=@kullanıcıadı AND şifre=@şifre";
                    cmd = new OleDbCommand(sorgu, bgl.bagla());
                    cmd.Parameters.AddWithValue("@kullanıcıadı", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@şifre", txtsifre.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Hatalı Bilgi. Tekrar Deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtkullaniciadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtkullaniciadi.Text != "" && txtsifre.Text != "")
                {
                    string sorgu = "SELECT * FROM AdminGirişBilgileri where kullanıcıadı=@kullanıcıadı AND şifre=@şifre";
                    cmd = new OleDbCommand(sorgu, bgl.bagla());
                    cmd.Parameters.AddWithValue("@kullanıcıadı", txtkullaniciadi.Text);
                    cmd.Parameters.AddWithValue("@şifre", txtsifre.Text);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Form2 frm = new Form2();
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Hatalı Bilgi. Tekrar Deneyiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tüm Alanları Doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}
