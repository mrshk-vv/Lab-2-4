using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using BaseExporter.Attributes;
using Newtonsoft.Json;

namespace DomainModel.Models
{
    [Serializable]
    [TableName("Переселения")]
    public class Resettlement : Base
    {
        private static int counter = 1;
        [DisplayName("Номер зачётной книжки")]
        public string GradeBookNumber { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public virtual Student Student
        {
            get => db.Students[db.Students.ToList().FindIndex(x => x.GradeBookNumber == GradeBookNumber)];
            set => GradeBookNumber = value.GradeBookNumber;
        }

        [DisplayName("Номер общежития")]
        public Hostel HostelNumber { get; set; }

        [DisplayName("Номер комнаты")]
        public int RoomId { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public virtual Room Room
        {
            get => db.Rooms[db.Rooms.ToList().FindIndex(x => x.Id == RoomId)];
            set => RoomId = value.Id;
        }

        [DisplayName("Дата вселения")]
        public DateTime CheckInDate { get; set; }

        private DateTime _chectOutDate;

        [DisplayName("Дата выселения")]
        public DateTime ChectOutDate
        {
            get
            {
                return _chectOutDate;
            }
            set
            {
                if (CheckInDate > value)
                    _chectOutDate = DateTime.Now;
                else
                    _chectOutDate = value;
            }
        }

        public Resettlement() 
        {
            Id = NewId;
            CheckInDate = DateTime.Now;
            ChectOutDate = CheckInDate.AddYears(1);
        }

        [JsonIgnore]
        private int NewId
        {
            get
            {
                if (db.Resettlements.ToList().Exists(item => item.Id == counter))
                    counter++;

                return counter;
            }
        }
    }
}

