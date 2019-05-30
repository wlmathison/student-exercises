using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise StudentExercises = new Exercise("Student Exercises", "C#");
            Exercise Lists = new Exercise("Lists", "C#");
            Exercise Dictionaries = new Exercise("Dictionaries", "C#");
            Exercise Classes = new Exercise("Classes", "C#");
            Exercise ConditionalRouting = new Exercise("Conditional Routing", "React");
            Exercise DynamicRouting = new Exercise("Dynamic Routing", "React");
            Exercise StateProps = new Exercise("State and Props", "React");
            Exercise URLRouting = new Exercise("URL Routing", "React");

            List<Exercise> Exercises = new List<Exercise>();
            Exercises.Add(StudentExercises);
            Exercises.Add(Lists);
            Exercises.Add(Dictionaries);
            Exercises.Add(Classes);
            Exercises.Add(ConditionalRouting);
            Exercises.Add(DynamicRouting);
            Exercises.Add(StateProps);
            Exercises.Add(URLRouting);

            Cohort ThirtyOne = new Cohort("31");
            Cohort ThirtyTwo = new Cohort("32");
            Cohort ThirtyThree = new Cohort("33");

            Student Billy = new Student("Billy", "Mathison", "Billy Mathison");
            Student Jameka = new Student("Jameka", "Echols", "Jameka");
            Student Alex = new Student("Alex", "Thacker", "Alex Thacker");
            Student Jonathan = new Student("Jonathan", "Schaffer", "Jonathan Schaffer");
            Billy.AddCohort(ThirtyOne);
            Jameka.AddCohort(ThirtyOne);
            Alex.AddCohort(ThirtyOne);
            Jonathan.AddCohort(ThirtyOne);

            List<Student> Students = new List<Student>();
            Students.Add(Billy);
            Students.Add(Jameka);
            Students.Add(Alex);
            Students.Add(Jonathan);

            Instructor Andy = new Instructor("Andy", "Collins", "andyc", "jokes");
            Instructor Leah = new Instructor("Leah", "Hoefling", "Leah", "dancing");
            Instructor Jisie = new Instructor("Jisie", "David", "jisie", "jokes");
            Instructor Kristen = new Instructor("Kristen", "Norris", "kristen.norris", "baking");
            Andy.AddCohort(ThirtyOne);
            Leah.AddCohort(ThirtyOne);
            Jisie.AddCohort(ThirtyThree);
            Kristen.AddCohort(ThirtyThree);

            Andy.AssignExercise(Billy, StudentExercises);
            Andy.AssignExercise(Billy, Lists);
            Andy.AssignExercise(Jameka, StudentExercises);
            Andy.AssignExercise(Jameka, Lists);
            Andy.AssignExercise(Alex, StudentExercises);
            Andy.AssignExercise(Alex, Lists);
            Andy.AssignExercise(Jonathan, StudentExercises);
            Andy.AssignExercise(Jonathan, Lists);
            Leah.AssignExercise(Billy, Dictionaries);
            Leah.AssignExercise(Billy, Classes);
            Leah.AssignExercise(Jameka, Dictionaries);
            Leah.AssignExercise(Jameka, Classes);
            Leah.AssignExercise(Alex, Dictionaries);
            Leah.AssignExercise(Alex, Classes);
            Leah.AssignExercise(Jonathan, Dictionaries);
            Leah.AssignExercise(Jonathan, Classes);
            Jisie.AssignExercise(Billy, ConditionalRouting);
            Jisie.AssignExercise(Billy, DynamicRouting);
            Jisie.AssignExercise(Jameka, ConditionalRouting);
            Jisie.AssignExercise(Jameka, DynamicRouting);
            Jisie.AssignExercise(Alex, ConditionalRouting);
            Jisie.AssignExercise(Alex, DynamicRouting);
            Jisie.AssignExercise(Jonathan, ConditionalRouting);
            Jisie.AssignExercise(Jonathan, DynamicRouting);
            Kristen.AssignExercise(Billy, StateProps);
            Kristen.AssignExercise(Billy, URLRouting);
            Kristen.AssignExercise(Jameka, StateProps);
            Kristen.AssignExercise(Jameka, URLRouting);
            Kristen.AssignExercise(Alex, StateProps);
            Kristen.AssignExercise(Alex, URLRouting);
            Kristen.AssignExercise(Jonathan, StateProps);
            Kristen.AssignExercise(Jonathan, URLRouting);

            foreach(Student student in Students) {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                foreach(Exercise exercise in student.AssignedExercises) {
                    Console.WriteLine($" - {exercise.Name} in {exercise.Language}");
                }
                Console.WriteLine("------------------------------");
            }
        }
    }
}