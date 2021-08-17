using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public class EnrolStudentMediator : IEnrolStudentMediator {
        public bool Handle(Student student) {
            ICourseSectionService courseSectionService = new CourseSectionService();
            INotificationService notificationService = new EmailNotificacionService();
            IBillingService billingService = new BillingService();
            // Add some new services...

            CourseSection courseSection = courseSectionService.AddStudent(student);
            notificationService.SendNotification(courseSection.Students);
            billingService.CalculateBill(courseSection);
            return true;
        }
    }
}
