using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserGroupStatus
{
    public class UserGroupStatusResultConverter 
        : BaseResultConverter<Model.UserGroupStatus, UserGroupStatusResult>, IUserGroupStatusResultConverter
    {
        public override void ConvertSpecific(Model.UserGroupStatus param, UserGroupStatusResult result)
        {

        }

        public override UserGroupStatusResult GetResult()
        {
            return new UserGroupStatusResult();
        }
    }
}
