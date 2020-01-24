namespace University_Management_System_API
{
    public abstract class NamedPersistent : Persistent
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
