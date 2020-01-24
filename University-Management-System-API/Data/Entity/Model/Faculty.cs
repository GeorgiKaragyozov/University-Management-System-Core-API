namespace University_Management_System_API.Model
{
    public class Faculty : NamedPersistent
    {
        public virtual FacultyStatus Status { get; set; }
    }
}
