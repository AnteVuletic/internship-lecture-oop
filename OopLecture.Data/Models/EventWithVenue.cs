namespace OopLecture.Data.Models
{
    public class EventWithVenue : Event
    {
        public Venue Venue { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} \n " +
                   $"{Venue}";
        }
    }
}
