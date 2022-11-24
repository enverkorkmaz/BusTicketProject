using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCoreTicketRepository : EfCoreGenericRepository<Ticket>,ITicketRepository
    {
        public EfCoreTicketRepository(GTContext _dbContext) : base(_dbContext)

        {

        }
        private GTContext context
        {
            get
            {
                return _dbContext as GTContext;
            }
        }
        
    }
}
