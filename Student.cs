using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {
        public Student(string firstName, string lastName, string slackHandle)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }
        public List<Exercise> AssignedExercises { get; set; } = new List<Exercise>();
        public void AddCohort(Cohort cohort)
        {
            Cohort = cohort;
        }
    }
}