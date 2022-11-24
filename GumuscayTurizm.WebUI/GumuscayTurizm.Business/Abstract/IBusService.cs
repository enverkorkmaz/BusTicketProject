using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface IBusService
    {
        int GetById(int busId);
        Task<List<Bus>> GetAllAsync();
        Task CreateAsync(Bus bus);
        void Update(Bus bus);
        void Delete(Bus bus);


    }
}
