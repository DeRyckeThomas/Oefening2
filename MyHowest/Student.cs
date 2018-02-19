using System;

namespace MyHowest
{

    public enum Graad
    {
        voldoening,
        Onderscheiding,
    }
    public class Student
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public Graad AfstudeerGraad { get; set; }

        public override string ToString()
        {
            return $"De student met {Naam} is met {AfstudeerGraad} afgestudeerd.";

        }
    }
}
