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
        Route GetRouteById(int id);
        void Create(Route route);
        void Update(Route route);
        void Delete(Route route);
        List<Route> GetAll();
        int GetFromWhereId(int fromWhereId);
        int GetToWhereId(int toWhereId);
        List<Route> GetRoute(int fromWhereId,int toWhereId);
        Route GetRouteDetails(int routeId);

    }
}
