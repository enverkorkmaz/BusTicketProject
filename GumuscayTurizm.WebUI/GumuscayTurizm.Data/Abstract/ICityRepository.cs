using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface ICityRepository : IRepository<City>
    {
        Task<List<City>> GetCitiesById(int id);

    }
}
