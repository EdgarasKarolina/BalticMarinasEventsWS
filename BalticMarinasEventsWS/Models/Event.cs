namespace BalticMarinasEventsWS.Models
{
    public class Event
    {
        internal int EventId { get; set; }
        internal string Title { get; set; }
        internal string Location { get; set; }
        internal string Period { get; set; }
        internal string Description { get; set; }
        internal int UserId { get; set; }
    }
}
