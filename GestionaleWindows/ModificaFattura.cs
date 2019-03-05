using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GestionaleWindows
{
    public partial class ModificaFattura : UserControl
    {
        public ModificaFattura()
        {
            InitializeComponent();

            string pathiniziale = prendipercorsodirectory();
            openFileDialog1.InitialDirectory = pathiniziale;
            saveFileDialog1.InitialDirectory = pathiniziale;



        }


        string percorsofile;
        string connessione = "Server=localhost;Database=" + ValoriStatici.NOME_DATABASE + ";Uid=root;Pwd=root;";
        MySql.Data.MySqlClient.MySqlConnection conn;

        FatturaElettronica.Fattura fatt;


        private void sceglifile(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.SafeFileName;
                percorsofile = openFileDialog1.FileName;
                nomefile.Text = file;
                trasformainfattura();
            }
        }


        public string prendipercorsodirectory()
        {
            string result = "";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select valoreimpostazione from impostazioni where nomeimpostazione = @nomeimpostazione";
                cmd.Parameters.AddWithValue("@nomeimpostazione", "pathfatture");
                cmd.Connection = conn;
                result = (string) cmd.ExecuteScalar();
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
            return result;
        }



        public void trasformainfattura()
        {
            fatt = new FatturaElettronica.Fattura();

            using (var r = System.Xml.XmlReader.Create(percorsofile, new System.Xml.XmlReaderSettings { IgnoreWhitespace = true, IgnoreComments = true }))
            {
                fatt.ReadXml(r);
            }
            
            string nomecliente = fatt.FatturaElettronicaHeader.CessionarioCommittente.DatiAnagrafici.Anagrafica.Denominazione;
            string piva = fatt.FatturaElettronicaHeader.CessionarioCommittente.DatiAnagrafici.IdFiscaleIVA.IdCodice;
            fsss.inserisciClienteDaFuori(nomecliente,piva);
            mostraprodottiaschermo();
  
        }

        public void chiusuraform()
        {
            saveFileDialog1.FileName = nomefile.Text;

            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string percorsosalvataggio = saveFileDialog1.FileName;

                using (var w = System.Xml.XmlWriter.Create(percorsosalvataggio, new System.Xml.XmlWriterSettings { Indent = true }))
                {
                    fatt.WriteXml(w);
                }
            }

 
        }


        public void apriformvariazioniheader()
        {
            FatturaElettronica.Forms.FatturaElettronicaForm form = new FatturaElettronica.Forms.FatturaElettronicaForm();
            form.FatturaElettronica = fatt;
            DialogResult result = form.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                chiusuraform();
            }

        }



        public void mostraprodottiaschermo()
        {
            int i = 0;
            foreach(FatturaElettronica.FatturaElettronicaBody.FatturaElettronicaBody corr in fatt.FatturaElettronicaBody)
            {
                foreach(FatturaElettronica.FatturaElettronicaBody.DatiBeniServizi.DettaglioLinee linea in corr.DatiBeniServizi.DettaglioLinee)
                {
                    
                    DataRow row = fsss.scelti.NewRow();

                    row["nomearticolo"] = linea.Descrizione;
                    row["prezzolistino"] = linea.PrezzoUnitario;
                    row["unitamisura"] = linea.UnitaMisura;
                    row["iva"] = linea.AliquotaIVA;
                    row["quantita"] = linea.Quantita;

                    fsss.scelti.Rows.Add(row);
                }
            }
        }


    }
}
