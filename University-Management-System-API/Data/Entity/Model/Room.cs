namespace University_Management_System_API.Model
{
    public class Room : NamedPersistent
    {
        public virtual RoomStatus Status { get; set; }
    }
}
