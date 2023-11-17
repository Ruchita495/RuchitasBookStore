using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuchitasBooks.DataAccess.Repository.IRepository
{
    interface UnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ICoverTypeRepository Covertype { get; }

        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }
    }
}
