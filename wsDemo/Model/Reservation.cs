using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace wsDemo.Model
{
    public class Reservation
    {

        public int Id { get; set; }
        public int IdClient { get; set; }
        public int IdRecepcionist { get; set; }
        public Room Room { get; set; }
        public string Name { get; set; }
        public string ArrivalDate { get; set; }
        public int Nights { get; set; }

        public Reservation() { }

        public Reservation(int id, int iC, int iR, Room room, string name, string date, int nights)
        {
            Id = id;
            IdClient = iC;
            IdRecepcionist = iR;
            Room = room;
            Name = name;
            ArrivalDate = date;
            Nights = nights;

        }

        public Reservation(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            IdRecepcionist = reader.GetInt32(2);
            IdClient = reader.GetInt32(1);
            Nights = reader.GetInt32(6);
            Name = reader.GetString(4);
            ArrivalDate = reader.GetString(5);
            Room r = new Room(

                 reader.GetInt32(7),
                 reader.GetString(8),
                 reader.GetString(9),
                 reader.GetString(10),
                 reader.GetValue(11) + "",
                 reader.GetInt32(12) == 1,
                 reader.GetString(13)
            );
            Room = r;

        }

    }
}