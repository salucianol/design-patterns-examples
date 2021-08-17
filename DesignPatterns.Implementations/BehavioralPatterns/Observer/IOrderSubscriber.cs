using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public interface IOrderSubscriber {
        string ReceiveNotification(Order order);
    }
}
