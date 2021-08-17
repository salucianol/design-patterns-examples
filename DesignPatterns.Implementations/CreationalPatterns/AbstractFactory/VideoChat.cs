using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    internal class VideoChat : IChat {
        private List<IMessage> messages;

        public VideoChat() {
            this.messages = new List<IMessage>();
        }

        public bool AddMessage(IMessage message) {
            if (this.messages.Count >= 2) {
                return false;
            }
            this.messages.Add(message);
            return true;
        }
    }
}
