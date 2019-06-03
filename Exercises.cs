using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Exercise
    {
        public Exercise(string name, string language, int id)
        {
            Name = name;
            Language = language;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}