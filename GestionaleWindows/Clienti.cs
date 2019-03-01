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
    public partial class Clienti : UserControl
    {
        public Clienti()
        {
            InitializeComponent();
            prendiclienti();
            datagridclienti.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }


        string connessione = "Server=localhost;Database=" + ValoriStatici.NOME_DATABASE + ";Uid=root;Pwd=root;";

        MySql.Data.MySqlClient.MySqlConnection conn;
        DataTable clienti = new DataTable();

        DataTable clientedestinazione = new DataTable();
        DataTable clientepiva = new DataTable();
        DataTable clienteemail = new DataTable();

        MySql.Data.MySqlClient.MySqlDataAdapter clientiadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder clientibuilder;

        MySql.Data.MySqlClient.MySqlDataAdapter destinazioniadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder destinazionibuilder;


        MySql.Data.MySqlClient.MySqlDataAdapter pivaadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder pivabuilder;

        MySql.Data.MySqlClient.MySqlDataAdapter emailadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder emailbuilder;

        public void prendiclienti()
        {
            try
            {
              
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente";
                cmd.Connection = conn;
                clientiadapter.SelectCommand = cmd;
                clientiadapter.Fill(clienti);
                clientibuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(clientiadapter);
                datagridclienti.DataSource = clienti;
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
            if(datagridclienti.SelectedRows.Count > 0)
            {
                string value1 = datagridclienti.SelectedRows[0].Cells[0].Value.ToString();
                prendidestinazionicliente(value1);
                prendipivacliente(value1);
                prendiemailcliente(value1);
            }
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
                cmd.Parameters.AddWithValue("@nomecli" , cliente);
                cmd.Connection = conn;
                destinazioniadapter.SelectCommand = cmd;
                destinazioniadapter.Fill(clientedestinazione);
                destinazionibuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(destinazioniadapter);
                datagriddestinazioni.DataSource = clientedestinazione;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        public void prendipivacliente(string cliente)
        {

            clientepiva.Clear();
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente_piva where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli", cliente);
                cmd.Connection = conn;
                pivaadapter.SelectCommand = cmd;
                pivaadapter.Fill(clientepiva);
                pivabuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(pivaadapter);
                datagridpartitaiva.DataSource = clientepiva;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        public void prendiemailcliente(string cliente)
        {

            clienteemail.Clear();
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente_email where nomecliente = @nomecli";
                cmd.Parameters.AddWithValue("@nomecli", cliente);
                cmd.Connection = conn;
                emailadapter.SelectCommand = cmd;
                emailadapter.Fill(clienteemail);
                emailbuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(emailadapter);
                datagridemail.DataSource = clienteemail;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }


        private void testocambiato(object sender, EventArgs e)
        {
            (datagridclienti.DataSource as DataTable).DefaultView.RowFilter = string.Format("nomecliente like '%{0}%'", textBox1.Text.Trim().Replace("'", "''"));
            datagridclienti.Refresh();
        }


        private void salvatutto(object sender, EventArgs e)
        {
            salvaclienti();
            salvadestinazioni();
            salvapiva();
            salvaemail();
            MessageBox.Show("SALVATO");
        }


        private void salvaclienti()
        {
            clientiadapter.Update(clienti);
     
        }

        private void salvadestinazioni()
        {
            destinazioniadapter.Update(clientedestinazione);
    
        }

        private void salvapiva()
        {
            pivaadapter.Update(clientepiva);
   
        }

        private void salvaemail()
        {
            emailadapter.Update(clienteemail);

        }




    }
}
