using RuchitasBooks.DataAccess.Repository.IRepository;
using RuchitasBookStore.DataAccess.Data;
using RuchitasBookStore.Models;
using System.Linq;
using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace RuchitasBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
            
        }
    }
}
