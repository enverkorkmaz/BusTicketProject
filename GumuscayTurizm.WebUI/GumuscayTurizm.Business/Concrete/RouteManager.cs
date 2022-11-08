using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Concrete
{
    public class RouteManager : IRouteService
    {
        public Task CreateAsync(Route route)
        {
            throw new NotImplementedException();
        }

        public void Delete(Route route)
        {
            throw new NotImplementedException();
        }

        public Task<List<Route>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Route> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Route route)
        {
            throw new NotImplementedException();
        }
    }
}
