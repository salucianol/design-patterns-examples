using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public interface IOrderPublisher {
        public ICollection<IOrderSubscriber> Subscribers { get; set; }
        void Subscribe(IOrderSubscriber orderSubscriber);
        void Unsubscribe(IOrderSubscriber orderSubscriber);
        void NotifySubscriber(Order order);
    }
}
