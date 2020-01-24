using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Room
{
    public class RoomResultConverter 
        : BaseResultConverter<Model.Room, RoomResult>, IRoomResultConverter
    {
        public override void ConvertSpecific(Model.Room param, RoomResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override RoomResult GetResult()
        {
            return new RoomResult();
        }
    }
}
