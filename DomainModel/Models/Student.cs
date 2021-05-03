using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DomainModel.Models
{
    [Serializable]
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

        public virtual IReadOnlyCollection<Resettlement> Resettlements
        {
            get => db.Resettlements.ToList().FindAll(x => x.GradeBookNumber == GradeBookNumber);
        }

        public Student()
        {
            Id = NewId;
        }

        private int NewId
        {
            get
            {
                if (db.Students.ToList().Exists(item => item.Id == counter))
                    counter++;

                return counter;
            }
        }

        public string FullName
        {
            get
            {
                return $"{Surname ?? "Unknown"} {Name?[0] ?? '?'}. {Patronymic?[0] ?? '?'}.";
            }
        }
    }


}
