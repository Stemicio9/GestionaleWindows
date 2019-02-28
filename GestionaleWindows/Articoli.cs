using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleWindows
{
    public partial class Articoli : UserControl
    {
        public Articoli()
        {
            InitializeComponent();
            prendiarticoli();
            datagridarticoli.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagridarticoli.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        MySql.Data.MySqlClient.MySqlConnection conn;
        DataTable articoli = new DataTable();


        MySql.Data.MySqlClient.MySqlDataAdapter articoliadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder articolibuilder;


        DataTable prezzoadhoc = new DataTable();

        MySql.Data.MySqlClient.MySqlDataAdapter hocadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder hocbuilder;


        public void prendiarticoli()
        {
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from articolo";
                cmd.Connection = conn;
                articoliadapter.SelectCommand = cmd;
                articoliadapter.Fill(articoli);
                articolibuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(articoliadapter);
                datagridarticoli.DataSource = articoli;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        private void selezionecambiata(object sender, EventArgs e)
        {
            if (datagridarticoli.SelectedRows.Count > 0)
            {
                string value1 = datagridarticoli.SelectedRows[0].Cells[0].Value.ToString();
                prendiprezziadhoc(value1);
            }
        }

        private void testocambiato(object sender, EventArgs e)
        {
            (datagridarticoli.DataSource as DataTable).DefaultView.RowFilter = string.Format("codicearticolo like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            datagridarticoli.Refresh();
        }




        public void prendiprezziadhoc(string codicearticolo)
        {
            prezzoadhoc.Clear();
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from prezzo_articolo_cliente where codicearticolo = @codice";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@codice" , codicearticolo);
                hocadapter.SelectCommand = cmd;
                hocadapter.Fill(prezzoadhoc);
                hocbuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(hocadapter);
                datagridprezziadhoc.DataSource = prezzoadhoc;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        private void salvatutto(object sender, EventArgs e)
        {
            salvaarticoli();
            salvaprezziadhoc();
            MessageBox.Show("SALVATO");
        }

        private void salvaarticoli()
        {
            articoliadapter.Update(articoli);

        }

        private void salvaprezziadhoc()
        {
            hocadapter.Update(prezzoadhoc);

        }

    }
}
