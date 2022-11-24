using GumuscayTurizm.Business.Abstract;
using GumuscayTurizm.Data.Abstract;
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
        private IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }

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

        public int GetById(int busId)
        {
            return _busRepository.GetById(busId);
        }

        public void Update(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}
