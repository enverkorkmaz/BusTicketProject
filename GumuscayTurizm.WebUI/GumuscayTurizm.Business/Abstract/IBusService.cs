using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface IBusService
    {
        void Create(Bus bus);
        Bus GetBusById(int id);
        void Update(Bus bus);
        void Delete(Bus bus);


    }
}
