using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace DomainModel
{
    [Serializable]
    public class Base
    {

        public Storage.Storage.DataBase db { get => Storage.Storage.Instance.db; }

        [DisplayName("Id")]
        public int Id { get; set; }
    }
}

