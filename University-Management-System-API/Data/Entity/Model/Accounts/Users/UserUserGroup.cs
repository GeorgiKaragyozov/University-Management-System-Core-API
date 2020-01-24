namespace University_Management_System_API.Model
{
    public class UserUserGroup : Persistent
    {
        public virtual User User { get; set; }

        public virtual UserGroup UserGroup { get; set; }
    }
}
