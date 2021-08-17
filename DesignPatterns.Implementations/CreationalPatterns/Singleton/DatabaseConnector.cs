using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;

namespace DesignPatterns.Core.Singleton {
    public class DatabaseConnector {
        private static DatabaseConnector databaseConnector;
        private DatabaseConnector() { }

        public static DatabaseConnector GetDatabaseConnector() {
            if (databaseConnector == null) {
                databaseConnector = new DatabaseConnector();
            }
            return databaseConnector;
        }

        public bool Connect() {
            return true;
        }
    }
}
