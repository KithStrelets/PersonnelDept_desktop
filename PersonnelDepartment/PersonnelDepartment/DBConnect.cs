using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using MySql.Data.MySqlClient;

namespace PersonnelDepartment
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        
        public DBConnect()
        {
            Initialize();
        }
        
        private void Initialize()
        {
            server = "localhost";
            database = "personnel";
            user = "root";
            password = "";
            string connectionString;
            connectionString = "server=" + server + ";" + "database=" + database + ";" + "user=" + user + ";" + "password=" + password + ";charset=utf8;;";

            connection = new MySqlConnection(connectionString);
            
        }
        
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password");
                        break;
                }
                return false;
            }
        }
        
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string Transform(string target)
        {
            string result;
            if (target == null) result = "";
            else { result = "\"" + target + "\""; }
            return result;
        }

        public void Insert(string table, params string[] parameters)
        {
            string query = "INSERT INTO "+table+" VALUES(" + string.Join(", ", parameters) + ")";
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);                
                cmd.ExecuteNonQuery();               
                this.CloseConnection();
            }
        }
        public void Update(string table, string where, params string[] parameters)
        {
            string query = "UPDATE "+table+" SET "+ string.Join(", ", parameters) + " WHERE "+where;
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
        public void Delete(string table, string where)
        {
            string query = "DELETE FROM "+table+" WHERE "+where;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }
       
        public List<string>[] Select(string table, int columnNumber, string what, string where)
        {
            if (what.Equals("")) what = "*";
            
            string query = "SELECT "+what+" FROM "+table+" WHERE "+where;
            
            List<string>[] list = new List<string>[] { };
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                int count = 0;
                while (dataReader.Read())
                {
                    count++;
                }
                dataReader.Close();
                dataReader = cmd.ExecuteReader();
                list = new List<string>[count];
                for (int a = 0;dataReader.Read(); a++)
                {

                    list[a] = new List<string>();
                    for (int inner = 0; inner < columnNumber; inner++)
                    {
                        try {
                            list[a].Add(dataReader.GetString(inner));
                        }
                        catch (System.Data.SqlTypes.SqlNullValueException) { list[a].Add(""); }
                    }
                }
                dataReader.Close();
                
                this.CloseConnection();
                
                return list;
            }
            else
            {
                return list;
            }
        }
        public string BoolToTiny(bool b)
        {
            string res;
            if (b) res = "1";
            else { res = "0"; }
            return res;
        }
       
        }
    
}
