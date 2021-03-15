using System;

namespace EventProject.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Local { get; set; }
        public DateTime Date { get; set; }
        public int NmrPeoples { get; set; }
        public string LotPurchase { get; set; }
        public string EventUrl { get; set; }
    }
}