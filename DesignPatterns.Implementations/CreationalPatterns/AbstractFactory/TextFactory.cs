using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    public class TextFactory : ICommunicationFactory {
        private string message;

        public TextFactory(string message) {
            this.message = message;
        }

        public IChat CreateChat() {
            return new TextChat();
        }

        public IMessage CreateMessage() {
            return new TextMessage(this.message);
        }
    }
}
