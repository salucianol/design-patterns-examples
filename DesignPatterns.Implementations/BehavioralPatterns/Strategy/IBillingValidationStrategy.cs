namespace DesignPatterns.Implementations.BehavioralPatterns.Strategy {
    public interface IBillingValidationStrategy {
        bool Validate(Bill bill);
    }
}
