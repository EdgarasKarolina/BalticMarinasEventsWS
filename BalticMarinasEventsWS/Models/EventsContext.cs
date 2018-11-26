using BalticMarinasEventsWS.Utilities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BalticMarinasEventsWS.Models
{
    public class EventsContext
    {
        public string ConnectionString { get; set; }

        public EventsContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Event> GetAllEvents()
        {
            List<Event> list = new List<Event>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Queries.GetAllEvents, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Event()
                        {
                            EventId = Convert.ToInt32(reader["EventId"]),
                            Title = reader["Title"].ToString(),
                            Location = reader["Location"].ToString(),
                            Period = reader["Period"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public Event GetEventById(int id)
        {
            var eventById = new Event();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(Queries.GetEventById, conn);
                cmd.Parameters.Add("@eventId", MySqlDbType.Int16).Value = id;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eventById.EventId = Convert.ToInt32(reader["EventId"]);
                        eventById.Title = reader["Title"].ToString();
                        eventById.Location = reader["Location"].ToString();
                        eventById.Period = reader["Period"].ToString();
                        eventById.Description = reader["Description"].ToString();
                    }
                }
            }
            return eventById;
        }

        public void CreateEvent(Event newEvent)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(Queries.CreateEvent, conn);
                    cmd.Parameters.Add("@title", MySqlDbType.VarChar).Value = newEvent.Title;
                    cmd.Parameters.Add("@location", MySqlDbType.VarChar).Value = newEvent.Location;
                    cmd.Parameters.Add("@period", MySqlDbType.VarChar).Value = newEvent.Period;
                    cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = newEvent.Description;

                    cmd.ExecuteReader();
                }
            }
            catch (Exception e)
            {
            }
        }

        public void DeleteEventById(int id)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(Queries.DeleteEventById, conn);
                    cmd.Parameters.Add("@eventId", MySqlDbType.Int16).Value = id;

                    cmd.ExecuteReader();
                }
            }
            catch (Exception e)
            {
                //this.logger.Error($"Error in DeleteRolePerSystem - {e}");
            }
        }
    }
}
