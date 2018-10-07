using System.Collections.Generic;
using System.Data;
using SolidPrinciples.SRP.DataAccess.Query;

namespace SolidPrinciples.SRP.DataAccess
{
    public interface ICustomerQuery
    {
        IEnumerable<Customer> Matching(Customer.Specification specification);
        IEnumerable<DataRow> MatchingRaw(Customer.Specification specification);
    }
}