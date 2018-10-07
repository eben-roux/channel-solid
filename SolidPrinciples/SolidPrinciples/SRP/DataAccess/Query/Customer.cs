using System;

namespace SolidPrinciples.SRP.DataAccess.Query
{
    public class Customer
    {
        public class Specification
        {
            public string MatchingName { get; private set; }

            public Specification WithNameMatching(string match)
            {
                MatchingName = match;

                return this;
            }
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}