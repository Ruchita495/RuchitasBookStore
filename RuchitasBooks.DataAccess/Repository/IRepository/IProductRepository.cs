using RuchitasBooks.DataAccess.Repository.IRepository;
using RuchitasBooks.Models;

namespace RuchitasBooks.DataAccess.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}