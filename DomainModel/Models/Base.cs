using System;

namespace DomainModel
{
    [Serializable]
    public class Base
    {
        public Storage.Storage.DataBase db { get => Storage.Storage.Instance.db; }

        public int Id { get; set; }
    }
}

