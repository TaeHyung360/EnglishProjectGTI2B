using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;

namespace wsDemo.Model
{
    public class Room
    {
        public int ID { get; set; }
        public string TypeRoom { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string UrlPhoto { get; set; }
        public bool Available { get; set; }

        public Room()
        {

        }

        public Room(int id, string typeRoom, string name, string description, string price, bool available, string urlPhoto)
        {
            ID = id;
            TypeRoom = typeRoom;
            Name = name;
            Description = description;
            Price = price;
            Available = available;
            UrlPhoto = urlPhoto;

        }

        public Room(SQLiteDataReader reader)
        {
            ID = reader.GetInt32(0);
            TypeRoom = reader.GetString(2);
            Name = reader.GetString(3);
            Description = reader.GetString(4);
            Price = reader.GetString(5);
            Available = reader.GetInt32(6)== 1;
            UrlPhoto = reader.GetString(7);
        }

    }
}