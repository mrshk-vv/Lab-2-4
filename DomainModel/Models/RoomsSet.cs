using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomainModel.Models
{
    public class RoomItem
    {
        public static readonly RoomItem Empty = new RoomItem { Id = null, RoomNumber = null};

        public int? Id { get; set; }
        public int? RoomNumber { get; set; }
    }

    public class RoomsSet : List<RoomItem> { }
}
