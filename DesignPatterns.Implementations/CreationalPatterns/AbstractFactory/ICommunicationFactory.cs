using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    public interface ICommunicationFactory {
        IMessage CreateMessage();
        IChat CreateChat();
    }
}
