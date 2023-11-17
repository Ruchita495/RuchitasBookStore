using RuchitasBooks.DataAccess.Repository.IRepository;
using RuchitasBookStore.DataAccess.Data;
using RuchitasBooks.Models;
using System.Linq;

namespace RuchitasBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            var objFromDb = _db.Covertypes.FirstOrDefault(c => c.Id == covertype.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = covertype.Name;

            }
        }
    }
}