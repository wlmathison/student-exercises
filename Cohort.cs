using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Cohort
    {
        public Cohort(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Student> StudentsInCohort { get; set; } = new List<Student>();
        public List<Instructor> InstructorsInCohort { get; set; } = new List<Instructor>();

        public void AddStudent(Student student)
        {
            StudentsInCohort.Add(student);
        }
        public void AddInstuctor(Instructor instructor)
        {
            InstructorsInCohort.Add(instructor);
        }
    }
}