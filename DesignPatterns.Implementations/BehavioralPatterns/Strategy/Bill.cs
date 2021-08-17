namespace DesignPatterns.Implementations.BehavioralPatterns.Strategy {
    public class Bill {
        public string Rnc { get; set; }
        public string Nombre { get; set; }
        public string ComprobanteFiscal { get; set; }
        public decimal Subtotal { get; set; } = 0.0M;
        public decimal Itbis { get; set; } = 0.0M;
        public decimal Descuento { get; set; } = 0.0M;
        public decimal Total { get; set; } = 0.0M;
    }
}