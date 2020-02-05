using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Discipline : NamedPersistent
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual DisciplineStatus Status { get; set; }
    }
}
