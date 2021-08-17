using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    internal class TextChat : IChat {
        private List<IMessage> messages;

        public TextChat() {
            this.messages = new List<IMessage>();
        }

        public bool AddMessage(IMessage message) {
            if (this.messages.Count >= 1) {
                return false;
            }
            this.messages.Add(message);
            return true;
        }
    }
}
