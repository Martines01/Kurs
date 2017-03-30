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

namespace WindowsFormsKurs
{
    public partial class Form1 : Form
    {
        List<Kurs> vieleKurse = null;
        List<Teilnehmer> vieleTeilnehmer = null;
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;//
        public Form1()
        {
            InitializeComponent();
            vieleKurse = new List<Kurs>();
            vieleTeilnehmer = new List<Teilnehmer>();
        }

        private void buttonDaten_Click(object sender, EventArgs e)
        {
            ladeDatenbank();
            erstelleCommando();
            leseDaten();

        }

        private void leseDaten()
        {
            //listBoxAusgabe.DataSource = null;
            //listArtikel.Clear();
            //while (reader.Read())
            //{
            //    listBoxAusgabe.Items.Add(mkArtikelObject(reader));
            //    //String zeile = reader["ArtikelNr"] + ": " + reader["Bezeichnung"];
            //    //listBoxAusgabe.Items.Add(zeile);
            //    listArtikel.Add(mkArtikelObject(reader));
            //}
            //reader.Close();
            //listBoxAusgabe.DataSource = listArtikel;
            //listBoxAusgabe.DisplayMember = "Display";
        }

        private void erstelleCommando()
        {
            //cmd = con.CreateCommand();
            //cmd.Parameters.Add("belibig", OleDbType.Integer);
            //String artgr = textBoxArtikelGruppe.Text;
            //cmd.CommandText = "Select * from tArtikel where Artikelgruppe = belibig";
            //cmd.CommandType = CommandType.Text;
            //try
            //{
            //    cmd.Parameters["belibig"].Value = textBoxArtikelGruppe.Text;
            //    reader = cmd.ExecuteReader();
            //    buttonRead.Enabled = true;

            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void ladeDatenbank()
        {
            con = new OleDbConnection();
            OleDbConnectionStringBuilder strgbild = new OleDbConnectionStringBuilder();
            strgbild.Provider = "Microsoft.ACE.OLEDB.12.0";
            strgbild.DataSource = "KursDB.accdb";
            con.ConnectionString = strgbild.ConnectionString;
            try
            {
                con.Open();
                
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exeption", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
