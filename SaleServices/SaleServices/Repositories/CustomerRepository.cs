using Dapper;
using CustomerServices.Context;
using CustomerServices.Models;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace CustomerServices.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _context;
        private readonly ApplicationDbContext _dbContext;
        public CustomerRepository(DapperContext context, ApplicationDbContext dbContext)
        {
            _context = context;
            _dbContext = dbContext;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var customer = await _dbContext.Customers.Where(s => s.CustomerId == id).SingleOrDefaultAsync();
            return customer;
            /* Dapper instead
            var query = $@"SELECT customer_id AS CustomerId,
       first_name AS FirstName,
       last_name AS LastName,
       phone AS Phone,
       email AS Email,
       street AS Street,
       city AS City,
       state AS State,
       zip_code AS ZipCode
FROM huynhlexuan_db.sales.customers
WHERE customer_id = @CustomerId;";

            using (var connection = _context.CreateConnection())
            {
                var parameters = new
                {
                    CustomerId = id
                };

                var Customer = await connection.QueryAsync<Customer>(query, param: parameters);
                return Customer.SingleOrDefault();
            }
            */
        }
    }
}
