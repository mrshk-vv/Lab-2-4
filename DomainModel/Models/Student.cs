using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Serialization;
using BaseExporter.Attributes;
using Newtonsoft.Json;

namespace DomainModel.Models
{
    [Serializable]
    [TableName("Студенты")]
    public class Student : Base
    {
        private static int counter = 1;

        [DisplayName("Номер зачётной книжки")]
        public string GradeBookNumber { get; set; }

        [DisplayName("Номер группы")]
        public string GroupNumber { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Отчество")]
        public string Patronymic { get; set; }


        [XmlIgnore]
        [JsonIgnore]
        public virtual IReadOnlyCollection<Resettlement> Resettlements
        {
            get => db.Resettlements.ToList().FindAll(x => x.GradeBookNumber == GradeBookNumber);
        }

        public Student()
        {
            Id = NewId;
        }

        [XmlIgnore]
        [JsonIgnore]
        private int NewId
        {
            get
            {
                if (db.Students.ToList().Exists(item => item.Id == counter))
                    counter++;

                return counter;
            }
        }

        [JsonIgnore]
        public string FullName
        {
            get
            {
                return $"{Surname ?? "Unknown"} {Name?[0] ?? '?'}. {Patronymic?[0] ?? '?'}.";
            }
        }
    }


}
