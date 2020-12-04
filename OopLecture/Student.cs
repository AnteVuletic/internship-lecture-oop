namespace OopLecture
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
