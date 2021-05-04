using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using DomainModel;
using DomainModel.Config;
using DomainModel.Mock;
using DomainModel.Models;
using DomainModel.Storage;
using static DomainModel.DataSeedingProvider;

namespace UserControls.Controls
{
    public partial class TabsContainer : UserControl
    {
        public TabsContainer()
        {
            InitializeComponent();
            SetRestrictions();
        }

        public Storage Bind
        {
            set
            {
                roomsView1.roomListBindingSource.DataSource = value.db.Rooms;
                resettlementsView1.resettlementListBindingSource.DataSource = value.db.Resettlements;
                studentsView1.studentListBindingSource.DataSource = value.db.Students;

                resettlementsView1.studentListBindingSource.DataSource = value.db.Students;
                resettlementsView1.roomListBindingSource.DataSource = value.db.Rooms;
            }
        }


        private void TabsContainer_Load(object sender, System.EventArgs e)
        {
            cbCascadeDeleting.Checked = DbOperationManager.AllowCascadeDeleting;

            
        }

        private void cbCascadeDeleting_Click(object sender, System.EventArgs e)
        {
            DbOperationManager.SwitchCascadeDeletingOption();
        }
    }
}

namespace UserControls.Controls
{
    public partial class TabsContainer
    {
        void SetRestrictions()
        {
            studentsView1.studentListBindingSource.AddingNew += NewStudent;
            roomsView1.roomListBindingSource.AddingNew += NewRoom;
            resettlementsView1.resettlementListBindingSource.AddingNew += NewResettlement;
            //
            studentsView1.studentListBindingSource.ListChanged += AllowNewResettlement;
            roomsView1.roomListBindingSource.ListChanged += AllowNewResettlement;
            //
            studentsView1.studentListBindingSource.PositionChanged += CheckStudentRelations;
            roomsView1.roomListBindingSource.PositionChanged += CheckRoomRelations;
        }

        private void AllowNewResettlement(object sender, ListChangedEventArgs e)
        {
            resettlementsView1.resettlementListBindingSource.AllowNew = Storage.Instance.AllowNewResettlement();
        }

        private void NewStudent(object sender, AddingNewEventArgs e)
        {
            var student = new Student
            {
                GradeBookNumber = Guid.NewGuid().ToString(),
                GroupNumber =
                    $"6{Randomizer.Next(1, 5)}{Randomizer.Next(1, 5)}",
                Name = MockData.Stundents.Names[Randomizer.Next(MockData.Stundents.Names.Count)],
                Surname = MockData.Stundents.Surnames[Randomizer.Next(MockData.Stundents.Surnames.Count)],
                Patronymic = MockData.Stundents.Patronymics[Randomizer.Next(MockData.Stundents.Patronymics.Count)],
            };
            e.NewObject = student;
        }
        
        private void NewRoom(object sender, AddingNewEventArgs e)
        {
            var room = new Room
            {
                FloorNumber = (Floor)Floors.GetValue(Randomizer.Next(Floors.Length)),
                HostelNumber = (Hostel)Hostels.GetValue(Randomizer.Next(Hostels.Length)),
                Capacity = (Capacity)Capacities.GetValue(Randomizer.Next(Capacities.Length)),
                RoomNumber = Randomizer.Next(100, 500)
            };
            e.NewObject = room;
        }

        private void NewResettlement(object sender, AddingNewEventArgs e)
        {
            var randomRoom = roomsView1.roomListBindingSource
                                       .List[Randomizer.Next(roomsView1.roomListBindingSource.List.Count)] as Room;

            var randomStudent = studentsView1.studentListBindingSource
                                             .List[Randomizer.Next(studentsView1.studentListBindingSource.List.Count)] as Student;
                        ;
            var resettlement = new Resettlement
            {
                GradeBookNumber = randomStudent?.GradeBookNumber,
                CheckInDate = GetRandomDate(),
                ChectOutDate = GetRandomDate(),
                HostelNumber = randomRoom?.HostelNumber ?? Hostel.First,
                RoomId = randomRoom?.Id ?? 1,
            };

            e.NewObject = resettlement;
        }

        private void CheckRoomRelations(object sender, EventArgs e)
        {
            if (roomsView1.roomListBindingSource.Current == null)
                return;

            var id = (roomsView1.roomListBindingSource.Current as Room)?.Id;
            roomsView1.bnRooms.DeleteItem.Enabled = Storage.Instance.AllowRemoveRoom(id.Value);
        }

        private void CheckStudentRelations(object sender, EventArgs e)
        {
            if (studentsView1.studentListBindingSource.Current == null) 
                return;

            var gradeBook = (studentsView1.studentListBindingSource.Current as Student)?.GradeBookNumber;
            studentsView1.bnStudents.DeleteItem.Enabled = Storage.Instance.AllowRemoveStudent(gradeBook);
        }
    }
}

namespace UserControls.Controls
{
    public partial class TabsContainer
    {
        public void ClearData()
        {
            studentsView1.ClearData();
            roomsView1.ClearData();
            resettlementsView1.ClearData();
        }
        public void UpdateData()
        {
            studentsView1.UpdateBinding();
            roomsView1.UpdateBinding();
            resettlementsView1.UpdateBinding();
        }
    }
}
