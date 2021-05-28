using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BaseExporter.Attributes;
using Newtonsoft.Json;

namespace DomainModel.Models
{
    [Serializable]
    [TableName("Комнаты")]
    public class Room : Base
    {
        private static int counter = 1;
        [DisplayName("Номер общежития")]
        public Hostel HostelNumber { get; set; }

        [DisplayName("Номер комнаты")]
        public int RoomNumber { get; set; }

        [DisplayName("Номер этажа")]
        public Floor FloorNumber { get; set; }

        [DisplayName("Вместимость")]
        public Capacity Capacity { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public virtual IReadOnlyCollection<Resettlement> Resettlements
        {
            get => db.Resettlements.ToList().FindAll(x => x.RoomId == Id);
        }

        public Room() 
        {
            Id = NewId;
        }

        [JsonIgnore]
        private int NewId
        {
            get
            {
                if (db.Rooms.ToList().Exists(item => item.Id == counter))
                    counter++;

                return counter;
            }
        }
    }

    public enum Capacity
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
    }

    public enum Floor
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5
    }

    public enum Hostel
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Eighth = 8,
        Ninth = 9,
        Tenth = 10,
        Eleventh = 11,
        Twelveth = 12,
    }
}

