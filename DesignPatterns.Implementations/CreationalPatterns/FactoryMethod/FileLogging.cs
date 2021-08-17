using System;
using System.IO;

namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    internal class FileLogging : ILogging {
        public void LogError(string message, Exception exception) {
            File.AppendAllText("errors-log.log", $"[ERROR] {message} | Exception message: {exception.Message}");
        }

        public void LogMessage(string message) {
            File.AppendAllText("messages-log.log", $"[INFO] {message}");
        }
    }
}
