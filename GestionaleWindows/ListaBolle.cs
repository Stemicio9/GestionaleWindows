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
    public partial class ListaBolle : UserControl
    {
        public ListaBolle()
        {
            InitializeComponent();
            datagridbolle.DataSource = ValoriStatici.bolle;
        }

        DataTable righebolla = new DataTable();
        MySql.Data.MySqlClient.MySqlConnection conn;

        MySql.Data.MySqlClient.MySqlDataAdapter rigabollaadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        MySql.Data.MySqlClient.MySqlCommandBuilder rigabollabuilder;

        private void bollaselezionata(object sender, EventArgs e)
        {
            if (datagridbolle.SelectedRows.Count > 0)
            {
                string numerodoc = datagridbolle.SelectedRows[0].Cells[0].Value.ToString();
                DateTime datadoc = (DateTime)datagridbolle.SelectedRows[0].Cells[1].Value;
                prendirighedibolla(numerodoc,datadoc);
            }
        }


        public void prendirighedibolla(string numerodoc, DateTime datadoc)
        {
            righebolla.Rows.Clear();
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from riga_bolla where numerodocumento = @numerodocumento and datadocumento = @datadocumento";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@numerodocumento", numerodoc);
                cmd.Parameters.AddWithValue("@datadocumento", datadoc);
                rigabollaadapter.SelectCommand = cmd;
                rigabollaadapter.Fill(righebolla);
                rigabollabuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(rigabollaadapter);
                datagridrighe.DataSource = righebolla;
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }

        }
    }
}
