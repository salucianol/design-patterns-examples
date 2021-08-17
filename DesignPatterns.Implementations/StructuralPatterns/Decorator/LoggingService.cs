using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace DesignPatterns.Implementations.StructuralPatterns.Decorator {
    public class LoggingService : ILoggingService {
        private MySqlConnection mysqlConnection;
        public IEnumerable<LogError> GetErrors() {
            List<LogError> logErrors = new List<LogError>();
            CreateDatabaseConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM log_errors", mysqlConnection);
            MySqlDataReader mysqlDataReader = mySqlCommand.ExecuteReader();
            while (mysqlDataReader.Read()) {
                logErrors.Add(new LogError {
                    Id = Convert.ToString(mysqlDataReader["id"]),
                    Message = Convert.ToString(mysqlDataReader["message"]),
                    ExceptionMessage = Convert.ToString(mysqlDataReader["exception_message"])
                });
            }
            return logErrors;
        }

        public IEnumerable<LogMessage> GetMessages() {
            List<LogMessage> logMessages = new List<LogMessage>();
            CreateDatabaseConnection();
            MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM log_messages", mysqlConnection);
            MySqlDataReader mysqlDataReader = mySqlCommand.ExecuteReader();
            while (mysqlDataReader.Read()) {
                logMessages.Add(new LogMessage {
                    Id = Convert.ToString(mysqlDataReader["id"]),
                    Message = Convert.ToString(mysqlDataReader["message"])
                });
            }
            return logMessages;
        }

        private void CreateDatabaseConnection() {
            mysqlConnection = new MySqlConnection("Server=<server_name>; Port=3306; Database=<database_name>; Uid=<username>; Pwd=<password>;");
            mysqlConnection.Open();
        }
    }
}
