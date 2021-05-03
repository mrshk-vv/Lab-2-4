using System;
using System.Collections.Generic;
using System.Linq;
using DomainModel.Config;
using DomainModel.Models;
using DomainModel.Storage.DomainModel;

namespace DomainModel.Storage
{
    public partial class Storage
    {
        private static readonly Storage instance = new Storage();
        public static Storage Instance { get => instance; }
        private Storage()
        {
            db = new DataBase();
        }

        public DataBase db { get; private set; }

        public class DataBase
        {
            public DataBase()
            {
                Resettlements = new ResettlementList();
                Rooms = new RoomList();
                Students = new StudentList();

                Students.CollectionChanged += Students_CollectionChanged;
                Rooms.CollectionChanged += Rooms_CollectionChanged;
            }

            private void Rooms_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        var room = e.OldItems[0] as Room; // get current room
                        Resettlements.Where(x => x.RoomId == room.Id)
                                     .ToList()
                                     .ForEach(r => Resettlements.Remove(r));
                        break;
                }
            }

            private void Students_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                        var student = e.OldItems[0] as Student; // get current student
                        Resettlements.Where(x => x.GradeBookNumber == student.GradeBookNumber)
                                     .ToList()
                                     .ForEach(r => Resettlements.Remove(r));
                        break;
                }
            }

            public ResettlementList Resettlements { get; set; }
            public RoomList Rooms { get; set; }
            public StudentList Students { get; set; }
        }
    }

    public partial class Storage
    {
        public bool AllowRemoveRoom(int roomId)
        {
            if (DbOperationManager.AllowCascadeDeleting)
                return true;

            return !db.Resettlements.Any(it => it.RoomId == roomId);
        }

        public bool AllowRemoveStudent(string gradeBookNumber)
        {
            if (DbOperationManager.AllowCascadeDeleting)
                return true;

            return !db.Resettlements.Any(it => it.GradeBookNumber == gradeBookNumber);
        }

        public bool AllowNewResettlement()
        {
            return (db.Rooms.Count > 0) && (db.Students.Count > 0);
        }


    }
}
