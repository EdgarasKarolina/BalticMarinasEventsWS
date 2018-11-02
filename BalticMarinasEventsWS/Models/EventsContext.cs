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
                MySqlCommand cmd = new MySqlCommand("select * from events", conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Event()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["name"].ToString(),
                            Location = reader["location"].ToString(),
                            Text = reader["text"].ToString()
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
                MySqlCommand cmd = new MySqlCommand("select * from events where id = @id", conn);
                cmd.Parameters.Add("@id", MySqlDbType.Int16).Value = id;

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eventById.Id = Convert.ToInt32(reader["Id"]);
                        eventById.Name = reader["name"].ToString();
                        eventById.Location = reader["location"].ToString();
                        eventById.Text = reader["text"].ToString();
                    }
                }
            }
            return eventById;
        }
    }
}
