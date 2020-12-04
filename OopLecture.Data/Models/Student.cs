using OopLecture.Data.Enums;

namespace OopLecture.Data.Models
{
    public class Student : Person
    {
        public UniversityType University { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} - {University}";
        }
    }
}
