using DocumentFormat.OpenXml.Drawing.Diagrams;
using RuchitasBooks.DataAccess.Repository.IRepository;
using RuchitasBooks.Models;
using RuchitasBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuchitasBooks.DataAccess.Repository
{
    public class UnitOfWork // make the method public
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            Covertype = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository Covertype { get; private set; }

        public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save() // all changes will be saved when the Save methode is called at the 'parent' level 
        {
            _db.SaveChanges();
        }
    }
}
