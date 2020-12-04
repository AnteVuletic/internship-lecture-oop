namespace OopLecture
{
    public class Professional : Person, IHourlyRateable
    {
        public decimal HourlyRate { get; set; }
        public decimal GetCost(int hours)
        {
            return HourlyRate * hours;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {HourlyRate} HRK/h";
        }
    }
}
