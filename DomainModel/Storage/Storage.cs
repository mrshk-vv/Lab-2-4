using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using DomainModel.Config;
using DomainModel.Models;
using DomainModel.Storage.DomainModel;
using Newtonsoft.Json;

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

        [Serializable]
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

            public ResettlementList Resettlements { get; set; }
            public RoomList Rooms { get; set; }
            public StudentList Students { get; set; }

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
        }
    }

    public partial class Storage
    {
        public bool AllowRemoveRoom(int roomId)
        {
            if (DbOperationManager.AllowCascadeDeleting)
                return true;

            return db.Resettlements.All(it => it.RoomId != roomId);
        }

        public bool AllowRemoveStudent(string gradeBookNumber)
        {
            if (DbOperationManager.AllowCascadeDeleting)
                return true;

            return db.Resettlements.All(it => it.GradeBookNumber != gradeBookNumber);
        }

        public bool AllowNewResettlement()
        {
            return (db.Rooms.Count > 0) && (db.Students.Count > 0);
        }


    }

    public partial class Storage
    {
        public enum Format { bin, xml, json }

        public bool Save(string path, Format format)
        {
            try
            {
                switch (format)
                {
                    case Format.bin:
                        SaveBin(path);
                        break;
                    case Format.xml:
                        SaveXml(path);
                        break;
                    case Format.json:
                        SaveJson(path);
                        break;
                    default:
                        throw new Exception($"{format} doesnt exist in available formats ");
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool Load(string filePath)
        {
            try
            {
                var fileInfo = new FileInfo(filePath);
                var extension = (Format)Enum.Parse(typeof(Format), fileInfo.Extension.TrimStart('.'));
                switch (extension)
                {
                    case Format.bin:
                        LoadBin(filePath);
                        break;
                    case Format.xml:
                        LoadXml(filePath);
                        break;
                    case Format.json:
                        LoadJson(filePath);
                        break;
                    default:
                        throw new Exception($"{extension} doesnt exist in available formats ");
                }

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void SaveJson(string filePath)
        {
            using (FileStream fs = new FileStream($"{filePath}.json", FileMode.Create))
            {
                var json = JsonConvert.SerializeObject(db, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                fs.Write(Encoding.ASCII.GetBytes(json), 0, json.Length);

                fs.Close();
            }
        }

        private void SaveBin(string filePath)
        {
            BinaryFormatter fmt = new BinaryFormatter();
            using (FileStream fs = new FileStream($"{filePath}.bin", FileMode.Create))
            {
                fmt.Serialize(fs, db);
                fs.Close();
            }
        }

        private void SaveXml(string filePath)
        {
            XmlSerializer xml = new XmlSerializer(db.GetType());
            using (FileStream fs = new FileStream($"{filePath}.xml", FileMode.Create))
            {
                xml.Serialize(fs, db);
                fs.Close();
            }
        }

        private void LoadJson(string path)
        {
            using (var file = File.OpenRead(path))
            using (StreamReader st = new StreamReader(file))
            {

                var jsonContent = st.ReadToEnd();
                var serializerDb = JsonConvert.DeserializeObject<DataBase>(jsonContent);
                SetDbData(serializerDb);
                st.Close();
                file.Close();
            }
        }

        private void LoadBin(string path)
        {
            BinaryFormatter fmt = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var serializedDb = fmt.Deserialize(fs) as DataBase;
                SetDbData(serializedDb);
                fs.Close();
            }
        }

        private void LoadXml(string path)
        {
            XmlSerializer xml = new XmlSerializer(db.GetType());
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                var serializedDb = xml.Deserialize(fs) as DataBase;
                SetDbData(serializedDb);
                fs.Close();
            }
        }

        private void SetDbData(DataBase db)
        {
            this.db.Students.Clear();
            foreach (var student in db.Students)
            {
                this.db.Students.Add(student);
            }

            this.db.Rooms.Clear();
            foreach (var room in db.Rooms)
            {
                this.db.Rooms.Add(room);
            }

            this.db.Resettlements.Clear();
            foreach (var resettlement in db.Resettlements)
            {
                this.db.Resettlements.Add(resettlement);
            }
        }
    }

}
