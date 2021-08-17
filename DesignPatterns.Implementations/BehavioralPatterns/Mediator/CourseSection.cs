using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Implementations.BehavioralPatterns.Mediator {
    public class CourseSection {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
