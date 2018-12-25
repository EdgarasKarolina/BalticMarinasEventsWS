using BalticMarinasEventsWS.Models;
using BalticMarinasEventsWS.Repositories;
using BalticMarinasEventsWS.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        // GET api/events
        [HttpGet]
        public IEnumerable<Event> GetAll()
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetAllEvents();
        }

        // GET api/events/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetEventById(id);
        }

        // GET api/users/3/
        [HttpGet("users/{id}")]
        public IEnumerable<Event> GetAllEventsByUserId(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetAllEventsByUserId(id);
        }

        // GET api/events/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            repository.DeleteEventById(id);
        }


        // POST api/events
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            repository.CreateEvent(newEvent);
        }
    }
}