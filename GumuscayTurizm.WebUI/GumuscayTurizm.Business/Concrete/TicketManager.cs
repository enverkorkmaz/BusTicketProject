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
    public class TicketManager : ITicketService
    {
        private ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task CreateAsync(Ticket ticket)
        {
            await _ticketRepository.CreateAsync(ticket);
        }

        public void Delete(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetByIdAsync(int id)
        {
            return _ticketRepository.GetByIdAsync(id);
        }

        public List<int> GetSelectedSeats(int tripId)
        {
            return _ticketRepository.GetSelectedSeats(tripId);
        }

        public void Update(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
