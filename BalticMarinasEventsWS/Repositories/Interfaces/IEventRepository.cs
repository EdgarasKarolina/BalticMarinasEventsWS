using BalticMarinasEventsWS.Models;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Repositories.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEventById(int id);
        void CreateEvent(Event newEvent);
        void DeleteEventById(int id);
    }
}
