using System;
using MySql.Data.MySqlClient;

namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    internal class DatabaseLogging : ILogging {
        private MySqlConnection mysqlConnection;
        public void LogError(string message, Exception exception) {
            CreateDatabaseConnection();
            MySqlCommand mysqlCommand = new MySqlCommand($"INSERT INTO log_errors VALUES('{Guid.NewGuid()}', '{message}', '{exception.Message}')", mysqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mysqlConnection.Close();
        }

        public void LogMessage(string message) {
            CreateDatabaseConnection();
            MySqlCommand mysqlCommand = new MySqlCommand($"INSERT INTO log_messages VALUES('{Guid.NewGuid()}', '{message}')", mysqlConnection);
            mysqlCommand.ExecuteNonQuery();
            mysqlConnection.Close();
        }

        private void CreateDatabaseConnection() {
            mysqlConnection = new MySqlConnection("Server=<server_name>; Port=3306; Database=<database_name>; Uid=<username>; Pwd=<password>;");
            mysqlConnection.Open();
        }
    }
}
