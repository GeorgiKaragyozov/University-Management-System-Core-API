﻿using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class UserUserGroup : Persistent
    {
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }

        [ForeignKey("UserGroup")]
        public long UserGroupId { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
