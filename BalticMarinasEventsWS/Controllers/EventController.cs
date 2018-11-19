using BalticMarinasEventsWS.Models;
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
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return context.GetAllEvents();
        }

        // GET api/event/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return context.GetEventById(id);
        }

        // GET api/event/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            context.DeleteEventById(id);
        }


        // POST api/event
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/event/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}