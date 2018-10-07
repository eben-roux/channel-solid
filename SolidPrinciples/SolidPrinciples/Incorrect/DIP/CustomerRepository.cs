using System.Data.SqlClient;

namespace SolidPrinciples.Incorrect.DIP
{
    public class CustomerRepository
    {
        private readonly SqlConnection _connection;

        public CustomerRepository(SqlConnection connection)
        {
            _connection = connection;
        }
    }
}