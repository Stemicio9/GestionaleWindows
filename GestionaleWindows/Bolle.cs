﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GestionaleWindows
{
    public partial class Bolle : UserControl
    {
        public Bolle()
        {
            InitializeComponent();
            prendiclienti();
         //   metodo();
            scelti.Columns.Add("codicearticolo", typeof(String));
            scelti.Columns.Add("nomearticolo", typeof(String));
            scelti.Columns.Add("prezzolistino", typeof(Decimal));
            scelti.Columns.Add("unitamisura", typeof(String));
            scelti.Columns.Add("iva", typeof(Decimal));
            scelti.Columns.Add("quantita", typeof(Decimal));
            listaarticoliscelti.DataSource = scelti;
            listaarticoliscelti.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaarticoliscelti.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaarticoliscelti.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaarticoliscelti.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaarticoliscelti.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            listaarticoliscelti.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.VisibleChanged += new EventHandler(this.visibile);
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            foreach (DataRow row in clienti.Rows){
                namesCollection.Add(row["nomecliente"].ToString());
            }

            textboxcliente.AutoCompleteCustomSource = namesCollection;
            textboxcliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            textboxcliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
        }



        public void visibile(object sender, EventArgs e)
        {   
            textBox1.Focus();
        }

        MySql.Data.MySqlClient.MySqlConnection conn;
        DataTable scelti = new DataTable();
        DataTable articoli = new DataTable();
        MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder cmbl;
        DataTable prezzocliente = new DataTable();


        string connessione = "Server=localhost;Database=" + ValoriStatici.NOME_DATABASE + ";Uid=root;Pwd=root;";


        DataTable clientedestinazione = new DataTable();

        MySql.Data.MySqlClient.MySqlDataAdapter destinazioniadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder destinazionibuilder;


        public void metodo()
        {
            articoli.Clear();
            try
            {
  
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from articolo";
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;            
                adapter.Fill(articoli);
                cmbl = new MySql.Data.MySqlClient.MySqlCommandBuilder(adapter);
                dataGridView1.DataSource = articoli;
                cmd = new MySql.Data.MySqlClient.MySqlCommand();
                string nomecli = textboxcliente.Text;
                string piva = getPartitaIvaDiCliente(nomecli);
                cmd.CommandText = "Select * from prezzo_articolo_cliente where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli",piva);
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
                adapter.Fill(prezzocliente);
                conn.Close();

                foreach(DataRow row in prezzocliente.Rows)
                {
                    foreach(DataRow art in articoli.Rows)
                    {
                        if (art["codicearticolo"].Equals(row["codicearticolo"]))
                        {
                            art["prezzolistino"] = (double)row["prezzocliente"] + 999999;
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        DataTable clienti = new DataTable();

        public void prendiclienti()
        {
            try
            {
              
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente";
                cmd.Connection = conn;
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(clienti);
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        public string getPartitaIvaDiCliente(string nomecli)
        {
            string result;
            try
            {
              
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select piva from cliente_piva where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli", nomecli);
                cmd.Connection = conn;
                string piva = (string)cmd.ExecuteScalar();
                result = piva;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
            return result;
        }

        private void testocambiato(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("codicearticolo like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            dataGridView1.Refresh();
        }

        private void tastopremutosucodicearticolo(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                maskedTextBox1.Focus();
            }
        }

        private void quantitapress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                DataRow row = scelti.NewRow();
                var arr = (dataGridView1.DataSource as DataTable).DefaultView.ToTable().Rows[0].ItemArray;
                row.SetField("codicearticolo",arr[0]);
                row.SetField("nomearticolo", arr[1]);
                row.SetField("prezzolistino", arr[2]);
                row.SetField("unitamisura", arr[3]);
                row.SetField("iva", arr[4]);
                row.SetField("quantita",maskedTextBox1.Text);
                scelti.Rows.Add(row);
                textBox1.Text = "";
                maskedTextBox1.Text = "";
                textBox1.Focus();
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void selezionato(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // String selItem = this.textBox1.Text;
                metodo();
                prendidestinazionicliente(textboxcliente.Text);
                riempipartitaiva(textboxcliente.Text);

                string ultimabollacreata = ValoriStatici.prendiultimonumerobolla();
                ultimabollacreatalabel.Text = ultimabollacreata;
                textBox1.Focus();
            }
        }

        private void salvaarticolo(object sender, EventArgs e)
        {
            adapter.Update(articoli);
            MessageBox.Show("SALVATO");
        }




        public void prendidestinazionicliente(string cliente)
        {

            clientedestinazione.Clear();
            try
            {
              
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente_destinazione where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli", cliente);
                cmd.Connection = conn;
                destinazioniadapter.SelectCommand = cmd;
                destinazioniadapter.Fill(clientedestinazione);
                destinazionibuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(destinazioniadapter);
            

                AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
                foreach (DataRow row in clientedestinazione.Rows)
                {
                    namesCollection.Add(row["indirizzo"].ToString());
                }

                destinazionetextbox.AutoCompleteCustomSource = namesCollection;
                destinazionetextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                destinazionetextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        public void riempipartitaiva(string nomecliente)
        {

            string piva = prendipivacliente(nomecliente);
            textboxpartitaiva.Text = piva;

            
        }

        public string prendipivacliente(string cliente)
        {
            string piva;
            try
            {
             
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select piva from cliente_piva where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli", cliente);
                cmd.Connection = conn;
                piva = (string) cmd.ExecuteScalar();

                conn.Close();

                return piva;
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkselezionato(object sender, EventArgs e)
        {
        }


        private void salvabolla(object sender, EventArgs e)
        {
            Bolla b = new Bolla();
            b.numerodocumento = textboxnumerobolla.Text;
            b.datadocumento = datascelta.Value;
            b.nomecliente = textboxcliente.Text;
            b.indirizzo = destinazionetextbox.Text;
            b.cap = "";
            b.piva = textboxpartitaiva.Text;
            b.telefono = "";
            b.peso = Double.Parse(textboxpeso.Text);
            b.numerocolli = int.Parse(textboxnumerocolli.Text);
            b.mezzo = listacheck.SelectedItem.ToString();
            b.impacchettamento = textboxaspettobeni.Text;

            ValoriStatici.aggiungibolla(b);
            ValoriStatici.inseriscirighe(scelti,b.numerodocumento,b.datadocumento);

        }

        //metodo che lega la creazione di un pdf al button con etichetta: "crea PDF"
        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Test1.pdf", FileMode.Create));
            doc.Open(); // apre il documento su cui scrivere

            //scrive qualcosa:
            Paragraph par1 = new Paragraph("Riga 1 di paragrafo 1\n");

            doc.Add(par1);
            doc.Close();
        }

        //metodo per il button "crea PDF e esporta datagridview1"
        //si serve di exportGridToPDF
        private void button3_Click(object sender, EventArgs e)
        {
            exportGridToPDF(scelti, "testgrid");
        }

        //esporta la grid in un pdf
        public void exportGridToPDF(DataTable dgw, String fileName)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);

            //quella giusta:
            PdfPTable pdfPTable = new PdfPTable(dgw.Columns.Count);
            //da canc:
           // PdfPTable pdfPTable = new PdfPTable(5);

            pdfPTable.DefaultCell.Padding = 3;
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfPTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //aggiunge l header:
            foreach (DataColumn column in dgw.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, textFont));
                //cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                pdfPTable.AddCell(cell);
            }

            //Add datarow
            foreach(DataRow row in dgw.Rows)
            {
                foreach(Object cell in row.ItemArray)
                {
                    pdfPTable.AddCell(new Phrase(cell.ToString(), textFont));
                }
            }

  

            string percorsoprova = "C:\\Users\\GMC\\Desktop\\percorsopdfwindows\\nome.pdf";
                using(FileStream stream = new FileStream(percorsoprova, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfPTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            


        }//chiusura exportGridToPdf(

        private void Bolle_Load(object sender, EventArgs e)
        {

        }
    }
}
