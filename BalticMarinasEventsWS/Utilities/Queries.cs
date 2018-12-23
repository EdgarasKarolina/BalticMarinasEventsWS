namespace BalticMarinasEventsWS.Utilities
{
    public static class Queries
    {
        public const string GetAllEvents = "select * from event";

        public const string GetEventById = "select * from event where EventId = @eventId";

        public const string GetAllEventsByUserId = "select * from event where UserId = @userId";

        public const string DeleteEventById = "delete from event where EventId = @eventId";

        public const string CreateEvent = "INSERT INTO event (Title, Location, Period, Description, UserId)\n" +
                    "VALUES (@title, @location, @period, @description, @userId);";
    }
}
