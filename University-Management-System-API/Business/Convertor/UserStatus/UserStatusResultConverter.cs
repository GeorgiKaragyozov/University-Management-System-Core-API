using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserStatus
{
    public class UserStatusResultConverter 
        : BaseResultConverter<Model.UserStatus, UserStatusResult>, IUserStatusResultConverter
    {
        public override void ConvertSpecific(Model.UserStatus param, UserStatusResult result) { }

        public override UserStatusResult GetResult()
        {
            return new UserStatusResult();
        }
    }
}
