using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator {
    public class ClientCollection : IIterable {
        private List<Client> items;
        private IIterator iterator;
        public IIterator Iterator {
            get {
                this.iterator = new ClientIterator(this);
                return this.iterator;
            }
        }

        public ClientCollection() {
            this.items = new List<Client>();
        }

        public IIterator CreateIterator() {
            return this.Iterator;
        }

        public void Add(Client client) {
            this.items.Add(client);
        }

        internal List<Client> GetClients() {
            return this.items;
        }
    }
}
