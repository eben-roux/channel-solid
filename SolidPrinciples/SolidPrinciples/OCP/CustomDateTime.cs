using System;

namespace SolidPrinciples.OCP
{
    public class CustomDateTime
    {
        public DateTime Value { get; }

        public CustomDateTime(DateTime value)
        {
            Value = value;
        }

        public int TotalYears(DateTime toDate)
        {
            if (Value > toDate)
            {
                throw new InvalidOperationException(
                    "The 'to' date passed has to be after the 'Value' date.");
            }

            var to = int.Parse(toDate.ToString("yyyyMMdd"));
            var from = int.Parse(Value.ToString("yyyyMMdd"));

            return (to - from) / 10000;
        }
    }
}