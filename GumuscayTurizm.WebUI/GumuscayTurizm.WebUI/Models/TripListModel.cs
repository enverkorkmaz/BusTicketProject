﻿using GumuscayTurizm.Entity;

namespace GumuscayTurizm.WebUI.Models
{
    public class TripListModel
    {
        public int fromWhereId { get; set; }
        public int toWhereId { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public City toWhere { get; set; }
        public City fromWhere { get; set; }

    }
}