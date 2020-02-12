using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.User
{
    public interface IUserParamConverter : IBaseParamConverter<UserParam, Model.User>
    {
        Model.User HashPassword(Model.User entity);
    }
}
