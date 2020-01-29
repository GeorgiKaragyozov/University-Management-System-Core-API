using University_Management_System_API.Business.Convertor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus;

namespace University_Management_System_API.Business.Convertor.UserGroup
{
    public class UserGroupParamConverter
        : BaseParamConverter<UserGroupParam, Model.UserGroup>, IUserGroupParamConverter
    {
        private IUserGroupStatusDao _statusDao;
        public IUserGroupStatusDao StatusDao
        {
            get { return _statusDao; }
            set { _statusDao = value; }
        }

        public UserGroupParamConverter(IUserGroupStatusDao statusDao)
        {
            this.StatusDao = statusDao;
        }

        public override Model.UserGroup GetEntity(UserGroupParam param)
        {
            return new Model.UserGroup
            {
                Id = param.Id,
                Code = param.Code
            };
        }

        public override void ConvertSpecific(UserGroupParam param, Model.UserGroup entity)
        {
            entity.Status = StatusDao.Find(param.StatusId);
        }
    }
}
