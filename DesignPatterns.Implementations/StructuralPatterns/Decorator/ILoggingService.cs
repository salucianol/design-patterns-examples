using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.StructuralPatterns.Decorator {
    public interface ILoggingService {
        IEnumerable<LogMessage> GetMessages();
        IEnumerable<LogError> GetErrors();
    }
}
