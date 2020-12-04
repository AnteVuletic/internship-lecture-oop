using System.Collections.Generic;
using OopLecture.Data.Abstractions;

namespace OopLecture.Data.Services
{
    public class HourlyBudgetCalculator
    {
        public int TimeSpanInHours { get; set; }
        public List<IHourlyRateable> HourlyRates { get; set; }


        public decimal TotalCost()
        {
            var total = 0m;
            foreach (var hourlyRateable in HourlyRates)
            {
                total += hourlyRateable.GetCost(TimeSpanInHours);
            }

            return total;
        }
    }
}
