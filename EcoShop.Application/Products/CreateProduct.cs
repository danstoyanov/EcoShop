using EcoShop.Database;
using EcoShop.Domain.Models;

namespace EcoShop.Application.Products
{
    public class CreateProduct
    {
        private ApplicationDbContext _context;

        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(int Id, string Name, string Description)
        {
            _context.Products.Add(new Product
            {
                Id = Id,
                Name = Name,
                Description = Description
            });
        }
    }
}
