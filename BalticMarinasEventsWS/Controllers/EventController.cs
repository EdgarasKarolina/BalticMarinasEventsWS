using BalticMarinasEventsWS.Models;
using BalticMarinasEventsWS.Repositories;
using BalticMarinasEventsWS.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        // GET api/event
        [HttpGet]
        public IEnumerable<Event> GetAll()
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetAllEvents();
        }

        // GET api/event/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetEventById(id);
        }

        [HttpGet("user/{id}")]
        public IEnumerable<Event> GetAllEventsByUserId(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            return repository.GetAllEventsByUserId(id);
        }

        // GET api/event/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            repository.DeleteEventById(id);
        }


        // POST api/event
        [HttpPost]
        public void Post([FromBody] Event newEvent)
        {
            IEventRepository repository = HttpContext.RequestServices.GetService(typeof(EventRepository)) as EventRepository;
            repository.CreateEvent(newEvent);
        }

        // PUT api/event/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}