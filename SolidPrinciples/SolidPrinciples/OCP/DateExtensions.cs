using System;

namespace SolidPrinciples.OCP
{
    public static class DateExtensions
    {
        public static int TotalYears(this DateTime toDate, DateTime fromDate)
        {
            if (fromDate > toDate)
            {
                throw new InvalidOperationException(
                    "The 'from' date passed has to be smaller than the 'to' date you are calling this function on.");
            }

            var to = int.Parse(toDate.ToString("yyyyMMdd"));
            var from = int.Parse(fromDate.ToString("yyyyMMdd"));

            return (to - from) / 10000;
        }
    }
}