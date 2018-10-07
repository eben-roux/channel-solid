using System;

namespace SolidPrinciples.Incorrect.SRP
{
    public class Customer
    {
        public Customer(Guid id)
        {
            Id = id;
        }

        public Customer(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }

        public void Save()
        {
            // save but we may have insufficient data
        }

        public void Load()
        {
            // load using the id
        }

        public Report InvoiceReport()
        {
            return new Report();
        }

        public void SendWelcomeMail()
        {
        }
    }
}