namespace DesignPatterns.Implementations.BehavioralPatterns.Strategy {
    public class Z50BillingValidationStrategy : IBillingValidationStrategy {
        public bool Validate(Bill bill) {
            decimal total = bill.Subtotal - bill.Descuento + bill.Itbis;
            if (bill.Total == total) {
                return true;
            }
            return false;
        }
    }
}
