using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    public interface ILogging {
        void LogMessage(string message);
        void LogError(string message, Exception exception);
    }
}
