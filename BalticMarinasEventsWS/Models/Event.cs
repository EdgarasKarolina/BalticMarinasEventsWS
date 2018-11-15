using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticMarinasEventsWS.Models
{
    public class Event
    {
        //private EventsContext context;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Text { get; set; }
    }
}
