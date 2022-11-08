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
        string GetCityByName(string cityName);
        int GetCityById(int id);
        void Create();
        void Update();
        void Delete();

    }
}
