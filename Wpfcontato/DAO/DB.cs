using System;
using SQLite;
using Wpfcontato.Model;
using System.Collections.Generic;
using System.Text;

namespace Wpfcontato.DAO
{
    public class DB
    {
        public string DB_NAME = "AulaContatos.db";
        public SQLiteConnection conn;
        public void openConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(this.databasePath());
            this.conn = connection;
            return;
        }

        public void closeConnection()
        {
            this.conn.Close();
            return;
        }
        public void createTables()
        {
            this.openConnection();

            // Create all necessary tables
            this.conn.CreateTable<Contato>();
            
            this.closeConnection();
            return;
        }
        public string databasePath()
        {
            string FOLDER_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string DB_PATH = System.IO.Path.Combine(FOLDER_PATH, this.DB_NAME);
            return DB_PATH;
        }
    }
}
