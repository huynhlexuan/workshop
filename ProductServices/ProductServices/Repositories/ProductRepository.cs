using Dapper;
using Microsoft.EntityFrameworkCore;
using ProductServices.Context;
using ProductServices.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServices.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DapperContext _context;
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(DapperContext context, ApplicationDbContext dbContext)
        {
            _context = context;
            _dbContext = dbContext;
        }

        public async Task<bool> CreateProductAsync(Product product)
        {
            try
            {
                await _dbContext.Set<Product>().AddAsync(product);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return false;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _dbContext.Products.Where(s => s.ProductId == id).SingleOrDefaultAsync();
            return product;
            /*Dapper instead
            var query = $@"SELECT product_id AS ProductId,
                   product_name AS ProductName,
                   brand_id AS BrandId,
                   category_id AS CategoryId,
                   model_year AS ModelYear,
                   list_price AS ListPrice
            FROM huynhlex_db.production.products
            WHERE product_id = @productId";
            using (var connection = _context.CreateConnection())
            {
                var parameters = new
                {
                    productId = id
                };

                var product = await connection.QueryAsync<ProductDetailDTO>(query, param: parameters);
                return product.SingleOrDefault();
            }
            */
        }
    }
}
