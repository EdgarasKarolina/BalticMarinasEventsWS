using BalticMarinasEventsWS.Models;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Repositories.Interfaces
{
    public interface IEventRepository
    {
        List<Event> GetAllEvents();
        Event GetEventById(int id);
        List<Event> GetAllEventsByUserId(int id);
        void CreateEvent(Event newEvent);
        void DeleteEventById(int id);
    }
}
