using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface IRouteService
    {
        Task<Route> GetByIdAsync(int id);
        Task<List<Route>> GetAllAsync();
        Task CreateAsync(Route route);
        void Update(Route route);
        void Delete(Route route);

    }
}
