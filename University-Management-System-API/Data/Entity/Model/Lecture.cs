using System.ComponentModel.DataAnnotations.Schema;

namespace University_Management_System_API.Model
{
    public class Lecture : NamedPersistent
    {
        [ForeignKey("TeacherDiscipline")]
        public long TeacherDisciplineId { get; set; }
        public virtual TeacherDiscipline TeacherDiscipline { get; set; }


        [ForeignKey("Room")]
        public long RoomId { get; set; }
        public virtual Room Room { get; set; }


        [ForeignKey("Status")]
        public long StatusId { get; set; }
        public virtual LectureStatus Status { get; set; }
    }
}
