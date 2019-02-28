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
    public partial class Informazioni : UserControl
    {
        public Informazioni()
        {
            InitializeComponent();
            prendiinformazioni();
            foreach(DataGridViewColumn col in datagridinformazioni.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        MySql.Data.MySqlClient.MySqlConnection conn;
        DataTable informazioni = new DataTable();

        MySql.Data.MySqlClient.MySqlDataAdapter informazioniadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder informazionibuilder;


        public void prendiinformazioni()
        {
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from informazioni";
                cmd.Connection = conn;
                informazioniadapter.SelectCommand = cmd;
                informazioniadapter.Fill(informazioni);
                informazionibuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(informazioniadapter);
                datagridinformazioni.DataSource = informazioni;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        private void salvainformazioni(object sender, EventArgs e)
        {
            informazioniadapter.Update(informazioni);
            MessageBox.Show("SALVATO");

        }
    }
}
