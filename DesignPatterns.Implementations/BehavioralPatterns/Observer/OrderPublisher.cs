using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Observer {
    public class OrderPublisher : IOrderPublisher {
        private List<IOrderSubscriber> subscribers = new List<IOrderSubscriber>();
        private List<Order> orders = new List<Order>();
        public ICollection<IOrderSubscriber> Subscribers {
            get {
                return subscribers;
            }
            set {
                subscribers = (List<IOrderSubscriber>)value;
            }
        }

        public void NotifySubscriber(Order order) {
            foreach (IOrderSubscriber orderSubscriber in Subscribers) {
                Console.WriteLine(orderSubscriber.ReceiveNotification(order));
            }
        }

        public void Subscribe(IOrderSubscriber orderSubscriber) {
            Subscribers.Add(orderSubscriber);
        }

        public void Unsubscribe(IOrderSubscriber orderSubscriber) {
            Subscribers.Remove(orderSubscriber);
        }

        public bool AddOrder(Order order) {
            orders.Add(order);
            NotifySubscriber(order);
            return true;
        }
    }
}
