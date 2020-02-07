using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Departament : PersistentNamed
    {
        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual DepartamentStatus Status { get; set; }
    }
}
