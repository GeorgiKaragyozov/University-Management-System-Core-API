﻿using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Room : NamedPersistent
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual RoomStatus Status { get; set; }
    }
}
