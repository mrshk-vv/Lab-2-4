using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using DomainModel.Models;

namespace DomainModel.Storage
{
    namespace DomainModel
    {
        [Serializable]
        public class ResettlementList : ObservableCollection<Resettlement>, IEnumerable<Resettlement> { }

        [Serializable]
        public class RoomList : ObservableCollection<Room>, IEnumerable<Room> { }

        [Serializable]
        public class StudentList : ObservableCollection<Student>, IEnumerable<Student> { }

    }
}
