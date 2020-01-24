using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.RoomStatus
{
    public class RoomStatusResultConverter 
        : BaseResultConverter<Model.RoomStatus, RoomStatusResult>, IRoomStatusResultConverter
    {
        public override void ConvertSpecific(Model.RoomStatus param, RoomStatusResult result) { }

        public override RoomStatusResult GetResult()
        {
            return new RoomStatusResult();
        }
    }
}
