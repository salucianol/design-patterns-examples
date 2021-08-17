using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator {
    public interface IIterator {
        int Count { get; }
        Client CurrentClient { get; }
        Client GetNext();
        bool HasNext();

    }
}
