using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface ICityService
    {
        string GetCityByName(string cityName);
        int GetCityById(int id);
        void Create();
        void Update();
        void Delete();
    }
}
