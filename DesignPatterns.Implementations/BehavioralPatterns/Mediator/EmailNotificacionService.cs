using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public class EmailNotificacionService : INotificationService {
        public bool SendNotification(ICollection<Student> students) {
            return true;
        }
    }
}
