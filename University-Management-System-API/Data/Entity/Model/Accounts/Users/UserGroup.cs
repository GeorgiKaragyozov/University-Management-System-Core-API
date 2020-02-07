using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class UserGroup : PersistentNamed
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }

        public virtual UserGroupStatus Status { get; set; }
    }
}
