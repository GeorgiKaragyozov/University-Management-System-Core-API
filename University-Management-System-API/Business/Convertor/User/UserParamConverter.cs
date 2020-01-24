using University_Management_System_API.DataAccess.DataAccessObject.UserStatus;
using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.User
{
    public class UserParamConverter 
        : BaseParamConverter<UserParam, Model.User>, IUserParamConverter
    {
        private IUserStatusDao _statusDao;
        public IUserStatusDao StatusDao
        {
            get { return this._statusDao; }
            set { this._statusDao = value; }
        }

        public UserParamConverter(IUserStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override Model.User GetEntity(UserParam param)
        {
            return new Model.User
            {
                Id = param.Id,
            };
        }

        public override void ConvertSpecific(UserParam param, Model.User entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
