using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public class CourseSectionService : ICourseSectionService {
        public CourseSection AddStudent(Student student) {
            // Implement the behavior for adding a student to section
            return new CourseSection();
        }
    }
}
