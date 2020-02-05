using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class TeacherDiscipline : NamedPersistent
    {
        [ForeignKey("Account")]
        public long AccountId { get; set; }
        public virtual Account Account { get; set; }

        [ForeignKey("Discipline")]
        public long DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }

        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual TeacherDisciplineStatus Status { get; set; }
    }
}
