using BalticMarinasEventsWS.Models;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Repositories.Interfaces
{
    public interface IEventRepository
    {
        void CreateEvent(Event newEvent);
        List<Event> GetAllEvents();
        Event GetEventById(int id);
        List<Event> GetAllEventsByUserId(int id);
        void DeleteEventById(int id);
    }
}
