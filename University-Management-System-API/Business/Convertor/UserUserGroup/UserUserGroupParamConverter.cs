using University_Management_System_API.Business.Convertor.Common;
using University_Management_System_API.DataAccess.DataAccessObject.User;
using University_Management_System_API.DataAccess.DataAccessObject.UserGroup;

namespace University_Management_System_API.Business.Convertor.UserUserGroup
{
    public class UserUserGroupParamConverter
         : BaseParamConverter<UserUserGroupParam, Model.UserUserGroup>, IUserUserGroupParamConverter
    {
        private IUserDao _userDao;
        public IUserDao UserDao
        {
            get { return this._userDao; }
            set { this._userDao = value; }
        }

        private IUserGroupDao _userGroupDao;
        public IUserGroupDao UserGroupDao
        {
            get { return this._userGroupDao; }
            set { this._userGroupDao = value; }
        }

        public UserUserGroupParamConverter(IUserDao userDao, IUserGroupDao userGroupDao)
        {
            this.UserDao = userDao;
            this.UserGroupDao = userGroupDao;
        }

        public override Model.UserUserGroup GetEntity(UserUserGroupParam param)
        {
            return new Model.UserUserGroup
            {
                Id = param.Id,
            };
        }

        public override void ConvertSpecific(UserUserGroupParam param, Model.UserUserGroup entity)
        {
            entity.User = UserDao.Find(param.UserId);
            entity.UserGroup = UserGroupDao.Find(param.UserGroupId);
        }
    }
}
