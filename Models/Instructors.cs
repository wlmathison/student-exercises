using System;

namespace student_exercises
{
    public class Instructor : NSSPerson
    {
        public Instructor(string firstName, string lastName, string slackHandle, string specialty, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Specialty = specialty;
            Id = id;
        }
        public string Specialty { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
            exercise.Students.Add(student);
        }
    }
}