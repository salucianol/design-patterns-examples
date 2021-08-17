namespace DesignPatterns.Implementations.CreationalPatterns.FactoryMethod {
    public class FileLoggingFactory : LoggingFactory {
        public override ILogging CreateLogging() {
            return new FileLogging();
        }
    }
}
