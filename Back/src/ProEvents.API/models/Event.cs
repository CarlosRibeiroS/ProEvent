using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEvents.API.models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string theme { get; set; }
        public int QuantityPeople { get; set; }
        public string Lot { get; set; }
        public string UrlImage { get; set; }
    }
}