using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public class BillingService : IBillingService {
        public decimal CalculateBill(CourseSection courseSections) {
            return Convert.ToDecimal(courseSections.Course.CreditsCount * 500);
        }
    }
}
