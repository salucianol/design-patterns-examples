using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.StructuralPatterns.Decorator {
    public class CacheLoggingService : ILoggingService {
        private readonly ILoggingService loggingService;
        private readonly IMemoryCache memoryCache;
        public CacheLoggingService(ILoggingService loggingService, IMemoryCache memoryCache) {
            this.loggingService = loggingService;
            this.memoryCache = memoryCache;
        }

        public IEnumerable<LogError> GetErrors() {
            List<LogError> logErrors;

            if (memoryCache.TryGetValue<List<LogError>>("koala_log_errors", out logErrors)) {
                return logErrors;
            }

            logErrors = (List<LogError>)loggingService.GetErrors();

            memoryCache.Set<List<LogError>>("koala_log_errors", logErrors);

            return logErrors;
        }

        public IEnumerable<LogMessage> GetMessages() {
            List<LogMessage> logMessages;

            if (memoryCache.TryGetValue<List<LogMessage>>("koala_log_messages", out logMessages)) {
                return logMessages;
            }

            logMessages = (List<LogMessage>)loggingService.GetMessages();

            memoryCache.Set<List<LogMessage>>("koala_log_messages", logMessages);

            return logMessages;
        }
    }
}
