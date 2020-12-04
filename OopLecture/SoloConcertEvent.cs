namespace OopLecture
{
    public class SoloConcertEvent : EventWithVenue
    {
        public Professional Singer { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} \n" +
                   $"Singer performing: {Singer} \n";
        }
    }
}
