using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        void Update();
        void Delete();

    }
}
