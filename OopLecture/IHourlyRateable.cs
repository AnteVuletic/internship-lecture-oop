namespace OopLecture
{
    public interface IHourlyRateable
    {
        decimal HourlyRate { get; set; }

        decimal GetCost(int hours);
    }
}
