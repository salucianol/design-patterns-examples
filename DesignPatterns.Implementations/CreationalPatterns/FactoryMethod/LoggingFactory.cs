using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    public abstract class LoggingFactory {
        public abstract ILogging CreateLogging();

        public void LogMessage(string message) {
            ILogging logging = CreateLogging();
            logging.LogMessage(message);
        }

        public void LogError(string message, Exception exception) {
            ILogging logging = CreateLogging();
            logging.LogError(message, exception);
        }
    }
}
