namespace DesignPatterns.Implementations.BehavioralPatterns.Strategy {
    public class BillingValidationStrategy : IBillingValidationStrategy {

        private readonly IBillingValidationStrategy _billingValidationStrategy;

        public BillingValidationStrategy(IBillingValidationStrategy 
                                            _billingValidationStrategy) {
            this._billingValidationStrategy 
                = _billingValidationStrategy;
        }

        public bool Validate(Bill bill) {
            return _billingValidationStrategy.Validate(bill);
        }
    }
}
