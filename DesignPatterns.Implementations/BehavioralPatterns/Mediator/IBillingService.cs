using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public interface IBillingService {
        decimal CalculateBill(CourseSection courseSections);
    }
}
