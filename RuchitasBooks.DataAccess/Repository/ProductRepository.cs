using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuchitasBooks.DataAccess.Repository.IRepository;
using RuchitasBookStore.DataAccess.Data;
using RuchitasBooks.Models;
using System.Threading.Tasks;

namespace RuchitasBooks.DataAccess.Repository
{
    public class ProductRepository : Repository<Product> , IProductRepository

    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            var objFromDb = _db.Products.FirstOrDefault(s => s.Id == product.Id);
            /*save changes if not null*/

            if(objFromDb != null)
            {
                if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }

                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
            }
        }

    }
}
