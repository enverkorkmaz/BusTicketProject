﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Entity
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string IdentificationNumber { get; set; }
        public string Email { get; set; }
        public List<Ticket> Tickets { get; set; }

    }
}
