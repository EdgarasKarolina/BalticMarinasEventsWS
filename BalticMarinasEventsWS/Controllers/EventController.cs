using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BalticMarinasEventsWS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BalticMarinasEventsWS.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            EventsContext context = HttpContext.RequestServices.GetService(typeof(BalticMarinasEventsWS.Models.EventsContext)) as EventsContext;
            return View(context.GetAllEvents());
        }
    }
}