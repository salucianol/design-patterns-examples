namespace DesignPatterns.Core.Iterator {
    public class ClientIterator : IIterator {
        private ClientCollection clientCollection;
        private int itemNumber = -1;

        public ClientIterator(ClientCollection clientCollection) {
            this.clientCollection = clientCollection;
        }

        public int Count {
            get {
                return clientCollection.GetClients().Count;
            }
        }

        public Client CurrentClient {
            get {
                if (this.itemNumber == -1) {
                    return null;
                } else if (this.itemNumber >= this.Count) {
                    return null;
                }
                return this.clientCollection.GetClients()[itemNumber];
            }
        }

        public Client GetNext() {
            return this.clientCollection.GetClients()[++itemNumber];
        }

        public bool HasNext() {
            return this.itemNumber >= this.Count - 1 ? false : true;
        }
    }
}