using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public class AccountSuscriber : IOrderSubscriber {
        public string ReceiveNotification(Order order) {
            return $"Account Subscriber: {order.Id}";
        }
    }
}
