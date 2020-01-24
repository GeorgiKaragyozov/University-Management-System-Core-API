namespace University_Management_System_API.Model
{
    public class TeacherDiscipline : NamedPersistent
    {
        public virtual Account Account { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual TeacherDisciplineStatus Status { get; set; }
    }
}
