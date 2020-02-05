using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class User : Persistent
    {
        public string Username { get; set; }
        public string Password { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual UserStatus Status { get; set; }
    }
}
