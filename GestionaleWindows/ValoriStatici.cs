using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaleWindows
{
    class ValoriStatici
    {

        public static string NOME_DATABASE = "backend";

        public static DataTable bolle = new DataTable();

        static MySql.Data.MySqlClient.MySqlConnection conn;
        static MySql.Data.MySqlClient.MySqlDataAdapter bolleadapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
        static MySql.Data.MySqlClient.MySqlCommandBuilder bollebuilder;


        public static void prendibolle()
        {
            try
            {
                string connessione = "Server=localhost;Database=backend;Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                cmd.CommandText = "Select * from bolla";
                cmd.Connection = conn;
                bolleadapter.SelectCommand = cmd;
                bolleadapter.Fill(bolle);
                bollebuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(bolleadapter);
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException e)
            {
                conn.Close();
                throw;
            }
        }



        public static string prendiultimonumerobolla()
        {
            string result = "";
            int max = 0;

   
            foreach (DataRow row in bolle.Rows)
            {
                try
                {
                    int curr = int.Parse((string)row["numerodocumento"]);

                    if (curr > max)
                    {
                        max = curr;
                    }
                }catch(Exception e)
                {
                    throw;
                }
            }
            result = max.ToString();
            return result;
        }



        public static void salvabolle()
        {
            bolleadapter.Update(bolle);

        }

        public static void aggiungibolla(Bolla b)
        {
            DataRow row = bolle.Rows.Add();
            row["numerodocumento"] = b.numerodocumento;
            row["datadocumento"] = b.datadocumento;
            row["nomecliente"] = b.nomecliente;
            row["indirizzo"] = b.indirizzo;
            row["cap"] = b.cap;
            row["piva"] = b.piva;
            row["telefono"] = b.telefono;
            row["peso"] = b.peso;
            row["numerocolli"] = b.numerocolli;
            row["mezzo"] = b.mezzo;
            row["impacchettamento"] = b.impacchettamento;

            salvabolle();
        }


        public static void inseriscirighe(DataTable righe, string numerodocumento, DateTime datadocumento)
        {
            string sql = @"insert into riga_bolla
             (numerodocumento,datadocumento,codicearticolo,quantita,prezzo,unitamisura,aliquota) 
             values (@numerodocumento,@datadocumento,@codicearticolo,@quantita,@prezzo,@unitamisura,@aliquota)";

            try
            {
                string connessione = "Server=localhost;Database="+NOME_DATABASE+";Uid=root;Pwd=root;";
                conn = new MySql.Data.MySqlClient.MySqlConnection(connessione);
                conn.Open();

                foreach (DataRow row in righe.Rows)
                {
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
                    cmd.CommandText = sql;
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@numerodocumento", numerodocumento);
                    cmd.Parameters.AddWithValue("@datadocumento", datadocumento);
                    cmd.Parameters.AddWithValue("@codicearticolo", row["codicearticolo"]);
                    cmd.Parameters.AddWithValue("@quantita", row["quantita"]);
                    cmd.Parameters.AddWithValue("@prezzo", row["prezzolistino"]);
                    cmd.Parameters.AddWithValue("@unitamisura", row["unitamisura"]);
                    cmd.Parameters.AddWithValue("@aliquota", row["iva"]);

                    int numerorigheaggiunte = cmd.ExecuteNonQuery();

                    MessageBox.Show("NUMERO RIGHE AGGIUNTE : " + numerorigheaggiunte);

                   
                }
                conn.Close();

            }
            catch(Exception e)
            {
                conn.Close();
                throw;
            }
        }



    }



}
