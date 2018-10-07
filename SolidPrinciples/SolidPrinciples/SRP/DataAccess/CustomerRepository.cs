using System;
using SolidPrinciples.SRP.Domain;

namespace SolidPrinciples.SRP.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository(/* depedencies */)
        {
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}