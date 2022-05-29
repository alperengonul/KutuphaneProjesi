using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace KütüphaneProjesi
{
    class baglanti
    {
        public OleDbConnection bagla()
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\kutuphaneprojesi.accdb");
            baglanti.Open();
            return baglanti;
        }
    }
}
