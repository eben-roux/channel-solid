using System;

namespace SolidPrinciples.SRP.Domain
{
    public interface ICustomerRepository
    {
        Customer Get(Guid id);
        void Save(Customer customer);
    }
}