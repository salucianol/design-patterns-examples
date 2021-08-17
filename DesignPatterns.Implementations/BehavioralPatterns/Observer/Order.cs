using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public class Order {
        public string Id { get; set; }
        public long Number { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}
