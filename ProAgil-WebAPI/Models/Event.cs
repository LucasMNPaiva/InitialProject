using System;

namespace EventProject.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventLocal { get; set; }
        public DateTime EventDate { get; set; }
        public string LotPurchase { get; set; }
        public string EventUrl { get; set; }
    }
}