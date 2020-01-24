namespace University_Management_System_API.Model
{
    public class UserGroup : NamedPersistent
    {
        public virtual UserGroupStatus Status { get; set; }
    }
}
