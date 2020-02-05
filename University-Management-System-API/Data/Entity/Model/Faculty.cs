using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Faculty : NamedPersistent
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual FacultyStatus Status { get; set; }
    }
}
