using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    public class DatabaseLoggingFactory : LoggingFactory {
        public override ILogging CreateLogging() {
            return new DatabaseLogging();
        }
    }
}
