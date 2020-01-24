using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.User
{
    public class UserResultConverter 
        : BaseResultConverter<Model.User, UserResult>, IUserResultConverter
    {
        public override void ConvertSpecific(Model.User param, UserResult result)
        {
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override UserResult GetResult()
        {
            return new UserResult();
        }
    }
}
