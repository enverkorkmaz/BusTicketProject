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

        public async Task CreateAsync(Bus bus)
        {
            await _busRepository.CreateAsync(bus);
        }

        public void Delete(Bus bus)
        {
            _busRepository.Delete(bus);
        }

        public async Task<List<Bus>> GetAllAsync()
        {
            return await _busRepository.GetAllAsync();
        }

        public int GetById(int busId)
        {
            return _busRepository.GetById(busId);
        }

        public Task<Bus> GetByIdAsync(int id)
        {
            return _busRepository.GetByIdAsync(id);
        }

        public void Update(Bus bus)
        {
            _busRepository.Update(bus);
        }
    }
}
