using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public interface ICourseSectionService {
        CourseSection AddStudent(Student student);
    }
}
