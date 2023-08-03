using System.Net;
using System.Runtime.Intrinsics.X86;

namespace StudentGrades
{
    public class Student
    {
        public string Name { get; set; }
        public decimal LabScore { get; set; }
        public decimal TestScore { get; set; }
        public Student() { }
    }
}