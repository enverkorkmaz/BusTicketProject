using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Concrete
{
    public class BusManager : IBusService
    {
        public Task CreateAsync(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void Delete(Bus bus)
        {
            throw new NotImplementedException();
        }

        public Task<List<Bus>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Bus> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}
