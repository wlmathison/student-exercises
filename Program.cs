using System;
using System.Collections.Generic;

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise StudentExercises = new Exercise("Student Exercises", "C#", 1);
            Exercise Lists = new Exercise("Lists", "C#", 2);
            Exercise Dictionaries = new Exercise("Dictionaries", "C#", 3);
            Exercise Classes = new Exercise("Classes", "C#", 4);
            Exercise ConditionalRouting = new Exercise("Conditional Routing", "React", 5);
            Exercise DynamicRouting = new Exercise("Dynamic Routing", "React", 6);
            Exercise StateProps = new Exercise("State and Props", "React", 7);
            Exercise URLRouting = new Exercise("URL Routing", "React", 8);

            List<Exercise> Exercises = new List<Exercise>();
            Exercises.Add(StudentExercises);
            Exercises.Add(Lists);
            Exercises.Add(Dictionaries);
            Exercises.Add(Classes);
            Exercises.Add(ConditionalRouting);
            Exercises.Add(DynamicRouting);
            Exercises.Add(StateProps);
            Exercises.Add(URLRouting);

            Cohort c31 = new Cohort("31", 1);
            Cohort c32 = new Cohort("32", 2);
            Cohort c33 = new Cohort("33", 3);

            Student Billy = new Student("Billy", "Mathison", "Billy Mathison", 1);
            Student Jameka = new Student("Jameka", "Echols", "Jameka", 2);
            Student Alex = new Student("Alex", "Thacker", "Alex Thacker", 3);
            Student Jonathan = new Student("Jonathan", "Schaffer", "Jonathan Schaffer", 4);
            Billy.Cohort = c31;
            Jameka.Cohort = c31;
            Alex.Cohort = c31;
            Jonathan.Cohort = c31;

            List<Student> Students = new List<Student>();
            Students.Add(Billy);
            Students.Add(Jameka);
            Students.Add(Alex);
            Students.Add(Jonathan);

            Instructor Andy = new Instructor("Andy", "Collins", "andyc", "jokes", 1);
            Instructor Leah = new Instructor("Leah", "Hoefling", "Leah", "dancing", 2);
            Instructor Jisie = new Instructor("Jisie", "David", "jisie", "jokes", 3);
            Instructor Kristen = new Instructor("Kristen", "Norris", "kristen.norris", "baking", 4);
            c31.Instructors.Add(Andy);
            Andy.Cohort = c31;
            c31.Instructors.Add(Leah);
            Leah.Cohort = c31;
            c31.Instructors.Add(Jisie);
            Jisie.Cohort = c33;
            c31.Instructors.Add(Kristen);
            Kristen.Cohort = c33;

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
                foreach(Exercise exercise in student.Exercises) {
                    Console.WriteLine($" - {exercise.Name} in {exercise.Language}");
                }
                Console.WriteLine("------------------------------");
            }
        }
    }
}