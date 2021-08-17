using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public class PaymentGatewayOrderSubscriber : IOrderSubscriber {
        public string ReceiveNotification(Order order) {
            return $"Payment gateway: Order #{order.Number} (Date: {order.ReceivedDate})";
        }
    }
}
