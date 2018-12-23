namespace BalticMarinasEventsWS.Utilities
{
    public static class Queries
    {
        public const string GetAllEvents = "SELECT * FROM event";

        public const string GetEventById = "SELECT * FROM event WHERE EventId = @eventId";

        public const string GetAllEventsByUserId = "SELECT * FROM event WHERE UserId = @userId";

        public const string DeleteEventById = "DELETE FROM event WHERE EventId = @eventId";

        public const string CreateEvent = "INSERT INTO event (Title, Location, Period, Description, UserId)\n" +
                    "VALUES (@title, @location, @period, @description, @userId);";
    }
}
