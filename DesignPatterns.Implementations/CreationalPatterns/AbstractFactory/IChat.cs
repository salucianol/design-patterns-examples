using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.AbstractFactory {
    public interface IChat {
        bool AddMessage(IMessage message);
    }
}
