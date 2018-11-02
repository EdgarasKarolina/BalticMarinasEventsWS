using BalticMarinasEventsWS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Event> GetAll()
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return context.GetAllEvents();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return context.GetEventById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}