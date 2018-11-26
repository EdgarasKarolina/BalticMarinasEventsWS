namespace BalticMarinasEventsWS.Utilities
{
    public static class Queries
    {
        public const string GetAllEvents = "select * from events";

        public const string GetEventById = "select * from events where EventId = @eventId";

        public const string DeleteEventById = "delete from events where EventId = @eventId";
    }
}
