using OopLecture.Data.Abstractions;

namespace OopLecture.Data.Models
{
    public class Venue : IHourlyRateable
    {
        public decimal TicketPrice { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal GetCost(int hours)
        {
            return HourlyRate * hours;
        }

        public override string ToString()
        {
            return $"Venue details: \n " +
                   $"\t Ticket Price: {TicketPrice} HRK \n" +
                   $"\t Capacity: {Capacity} people \n" +
                   $"\t Location: {Location} \n" +
                   $"\t Hourly Rate: {HourlyRate} HRK/h";
        }
    }
}
