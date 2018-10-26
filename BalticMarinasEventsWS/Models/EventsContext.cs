using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                        });
                    }
                }
            }
            return list;
        }
    }
}
