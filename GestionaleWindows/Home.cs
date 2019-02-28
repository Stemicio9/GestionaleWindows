using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleWindows
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void click(object sender, EventArgs e)
        {
            metodo();
        }

        MySql.Data.MySqlClient.MySqlConnection conn;



        private void metodo()
        {
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from cliente";
                cmd.Connection = conn;
                //        MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.Columns["nome"].Visible = false;
                dataGridView1.Columns["nomecliente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                conn.Close();
            }
            /*        while (reader.Read())
                    {
                        string valorecorrente = reader["nomecliente"].ToString();
                     //   listView1.Items.Add(valorecorrente);
                        listBox1.Items.Add(valorecorrente);
                    }
                } */
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }

        private void cambiacursore(object sender, EventArgs e)
        {
         //   listView1.Items.Clear();
         //   listView1.Items.Add(listBox1.SelectedItem.ToString());
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        Dashboard dash = new Dashboard();
        Bolle b = new Bolle();
        ListaBolle listabolle = new ListaBolle();
        Fatture fatture = new Fatture();
        ListaFatture listafatture = new ListaFatture();
        Articoli articoli = new Articoli();
        Clienti clienti = new Clienti();

        private void settaTuttoInvisibile()
        {
            dash.Visible = false;
            b.Visible = false;
            listabolle.Visible = false;
            fatture.Visible = false;
            listafatture.Visible = false;
            articoli.Visible = false;
            clienti.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            dash.Visible = true;
            pannellocentrale.Controls.Add(dash);
        }

        private void bolleclick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();         
            b.Dock = DockStyle.Left;
            b.Visible = true;
            pannellocentrale.Controls.Add(b);
        }

        private void listabolleclick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            listabolle.Visible = true;
            pannellocentrale.Controls.Add(listabolle);
        }

        private void fattureclick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            fatture.Visible = true;
            pannellocentrale.Controls.Add(fatture);
        }

        private void listafattureclick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            listafatture.Visible = true;
            pannellocentrale.Controls.Add(listafatture);
        }

        private void articoliclick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            articoli.Visible = true;
            pannellocentrale.Controls.Add(articoli);
        }

        private void clienticlick(object sender, EventArgs e)
        {
            settaTuttoInvisibile();
            pannellocentrale.Controls.Clear();
            clienti.Visible = true;
            pannellocentrale.Controls.Add(clienti);
        }


    }
}
