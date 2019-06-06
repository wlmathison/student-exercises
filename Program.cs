using System;
using System.Collections.Generic;
using System.Linq;

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
            Exercise Inheritance = new Exercise("Inheritance", "C#", 9);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(StudentExercises);
            exercises.Add(Lists);
            exercises.Add(Dictionaries);
            exercises.Add(Classes);
            exercises.Add(ConditionalRouting);
            exercises.Add(DynamicRouting);
            exercises.Add(StateProps);
            exercises.Add(URLRouting);
            exercises.Add(Inheritance);

            Cohort c31 = new Cohort("31", 1);
            Cohort c32 = new Cohort("32", 2);
            Cohort c33 = new Cohort("33", 3);

            List<Cohort> cohorts = new List<Cohort>();
            cohorts.Add(c31);
            cohorts.Add(c32);
            cohorts.Add(c33);

            Student Billy = new Student("Billy", "Mathison", "Billy Mathison", 1);
            Student Jameka = new Student("Jameka", "Echols", "Jameka", 2);
            Student Alex = new Student("Alex", "Thacker", "Alex Thacker", 3);
            Student Jonathan = new Student("Jonathan", "Schaffer", "Jonathan Schaffer", 4);
            Student Chris = new Student("Chris", "Morgan", "Chris Blue", 5);

            c31.Students.Add(Billy);
            Billy.Cohort = c31;
            c31.Students.Add(Jameka);
            Jameka.Cohort = c31;
            c31.Students.Add(Alex);
            Alex.Cohort = c31;
            c31.Students.Add(Jonathan);
            Jonathan.Cohort = c31;
            c31.Students.Add(Chris);
            Chris.Cohort = c31;

            List<Student> students = new List<Student>();
            students.Add(Billy);
            students.Add(Jameka);
            students.Add(Alex);
            students.Add(Jonathan);
            students.Add(Chris);

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

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(Andy);
            instructors.Add(Leah);
            instructors.Add(Jisie);
            instructors.Add(Kristen);

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
            Andy.AssignExercise(Billy, Inheritance);

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($" - {exercise.Name} in {exercise.Language}");
                }
                Console.WriteLine("-------------------------------------------");
            }

            Console.WriteLine("React Exercises:");
            foreach (Exercise exercise in exercises.Where(exercise => exercise.Language == "React"))
            {
                Console.WriteLine($" - {exercise.Name}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Cohort 31 Students:");
            foreach (Student student in students.Where(student => student.Cohort == c31))
            {
                Console.WriteLine($" - {student.FirstName} {student.LastName}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Cohort 31 Instructors:");
            foreach (Instructor instructor in instructors.Where(instructor => instructor.Cohort == c31))
            {
                Console.WriteLine($" - {instructor.FirstName} {instructor.LastName}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Students in alphabetical order:");
            foreach (Student student in students.OrderBy(student => student.LastName))
            {
                Console.WriteLine($" - {student.FirstName} {student.LastName}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Students not working on any exercises currently:");
            foreach (Student student in students.Where(student => student.Exercises.Count == 0))
            {
                Console.WriteLine($" - {student.FirstName} {student.LastName}");
            }
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Student working on the most exercises currently:");
            Student StudentWithMostExercises = students.OrderByDescending(student => student.Exercises.Count).ToList()[0];
            Console.WriteLine($" - {StudentWithMostExercises.FirstName} {StudentWithMostExercises.LastName} : {StudentWithMostExercises.Exercises.Count}");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Number of students in each cohort:");
            foreach (Cohort cohort in cohorts)
            {
                Console.WriteLine($" - {cohort.Name}: {cohort.Students.Count}");
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}