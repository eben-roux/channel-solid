using System.Data;

namespace SolidPrinciples.DIP
{
    public class CustomerRepository
    {
        private readonly IDbConnection _connection;

        public CustomerRepository(IDbConnection connection)
        {
            _connection = connection;
        }
    }
}