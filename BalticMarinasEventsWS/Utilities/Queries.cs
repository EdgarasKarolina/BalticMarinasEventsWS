using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BalticMarinasEventsWS.Utilities
{
    public static class Queries
    {
        public const string GetAllEvents = "select * from events";

        public const string GetEventById = "select * from events where id = @id";

        public const string DeleteEventById = "delete from events where id = @id";
    }
}
