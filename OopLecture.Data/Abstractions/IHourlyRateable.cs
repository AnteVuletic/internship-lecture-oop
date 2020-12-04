namespace OopLecture.Data.Abstractions
{
    public interface IHourlyRateable
    {
        decimal HourlyRate { get; set; }

        decimal GetCost(int hours);
    }
}
