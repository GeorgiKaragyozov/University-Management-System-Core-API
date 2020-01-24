using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserGroup
{
    public class UserGroupResultConverter
        : BaseResultConverter<Model.UserGroup, UserGroupResult>,
           IUserGroupResultConverter
    {
        public override void ConvertSpecific(Model.UserGroup param, UserGroupResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override UserGroupResult GetResult()
        {
            return new UserGroupResult();
        }
    }
}
