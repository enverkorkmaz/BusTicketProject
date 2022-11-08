using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Business.Abstract
{
    public interface ITıcketService
    {
        Ticket GetById(int id);
        List<Ticket> GetAll();
        void Delete(Ticket ticket);
        void Update(Ticket ticket);
        void Create(Ticket ticket);
        int GetCountBySeat(int tripId);
        List<int> GetSeat(int tripId);
        int GetId(int id);

    }
}
