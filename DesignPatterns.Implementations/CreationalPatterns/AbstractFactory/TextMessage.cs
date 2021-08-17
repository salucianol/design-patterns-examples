using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    internal class TextMessage : IMessage {
        private string message;
        public TextMessage(string message) {
            this.message = message;
        }
        public long GetLength() {
            return message.Length;
        }
    }
}
