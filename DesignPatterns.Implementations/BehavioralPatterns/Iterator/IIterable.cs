using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Core.Iterator {
    public interface IIterable {
        IIterator CreateIterator();
    }
}
