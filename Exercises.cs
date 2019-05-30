using System;

namespace student_exercises
{
    public class Exercise
    {
        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }
        public string Name { get; set; }
        public string Language { get; set; }
    }
}