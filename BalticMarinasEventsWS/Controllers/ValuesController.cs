using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalticMarinasEventsWS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalticMarinasEventsWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Event> GetAll()
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return context.GetAllEvents();
        }

        /*
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;

            var belekas = context.GetAllEvents();

            return new string[] { "value1", "value2" };
        }
        */

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
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
