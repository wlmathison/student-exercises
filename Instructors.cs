using System;

namespace student_exercises
{
    public class Instructor
    {
        public Instructor(string firstName, string lastName, string slackHandle, string specialty)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Specialty = specialty;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Specialty { get; set; }
        public Cohort Cohort { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.AssignedExercises.Add(exercise);
        }
        public void AddCohort(Cohort cohort)
        {
            Cohort = cohort;
        }
    }
}