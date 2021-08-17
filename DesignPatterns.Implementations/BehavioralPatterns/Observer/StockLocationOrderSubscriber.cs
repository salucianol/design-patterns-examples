using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public class StockLocationOrderSubscriber : IOrderSubscriber {
        public string ReceiveNotification(Order order) {
            return $"Stock Location: Order #{order.Number} (Date: {order.ReceivedDate})";
        }
    }
}
