namespace DesignPatterns.Implementations.BehavioralPatterns.Strategy {
    public class Z51BillingValidationStrategy : IBillingValidationStrategy {
        public bool Validate(Bill bill) {
            decimal total = bill.Subtotal + bill.Itbis;
            if (bill.Total == total) {
                return true;
            }
            return false;
        }
    }
}
