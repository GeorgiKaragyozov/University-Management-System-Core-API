namespace University_Management_System_API.Model
{
    public class Lecture : NamedPersistent
    {
        public virtual TeacherDiscipline TeacherDiscipline { get; set; }

        public virtual Room Room { get; set; }

        public virtual LectureStatus Status { get; set; }
    }
}
