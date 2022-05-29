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
    public partial class Form8 : Form
    {
        baglanti bgl = new baglanti();
        OleDbCommand cmd;
        OleDbDataReader dr;
        private void üyelistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM ÜyeBilgileri", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView1.DataSource = doldur;
            bgl.bagla().Close();
        }
        private void kitaplistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM KitapBilgileri", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView2.DataSource = doldur;
            bgl.bagla().Close();
        }
        private void emanetkitaplistesi()
        {
            OleDbDataAdapter veri = new OleDbDataAdapter();
            veri = new OleDbDataAdapter("SELECT * FROM EmanetKitap", bgl.bagla());
            DataTable doldur = new DataTable();
            veri.Fill(doldur);
            dataGridView3.DataSource = doldur;
            bgl.bagla().Close();
        }
        public Form8()
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

        private void Form8_Load(object sender, EventArgs e)
        {
            üyelistesi();
            kitaplistesi();
            emanetkitaplistesi();
            lbluyesayisi.Text = dataGridView1.Rows.Count.ToString();
            lblkitapsayisi.Text = dataGridView2.Rows.Count.ToString();
            lblemanetverilenkitapsayisi.Text = dataGridView3.Rows.Count.ToString();
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
