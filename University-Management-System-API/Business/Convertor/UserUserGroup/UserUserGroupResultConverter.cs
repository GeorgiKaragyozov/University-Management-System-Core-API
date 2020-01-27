using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.UserUserGroup
{
    public class UserUserGroupResultConverter
        : BaseResultConverter<Model.UserUserGroup, UserUserGroupResult>, IUserUserGroupResultConverter
    {
        public override void ConvertSpecific(Model.UserUserGroup param, UserUserGroupResult result)
        {
            result.UserId = param.User.Id;
            result.UserName = param.User.Username;

            result.UserGroupId = param.UserGroup.Id;
            result.UserGroupName = param.UserGroup.Name;
        }

        public override UserUserGroupResult GetResult()
        {
            return new UserUserGroupResult();
        }
    }
}
