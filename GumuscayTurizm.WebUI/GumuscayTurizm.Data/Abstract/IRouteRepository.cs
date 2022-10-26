using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Abstract
{
    public interface IRouteRepository: IRepository<Route>
    {
        int FromWhereId(int fromWhereId);
        int ToWhereId(int toWhereId);
        List<Route> GetRoute(int fromWhereId,int toWhereId);
        int GetRouteParent(int fromWhereId,int toWhereId);
        Route GetRouteDetailsById(int id);

    }
}
