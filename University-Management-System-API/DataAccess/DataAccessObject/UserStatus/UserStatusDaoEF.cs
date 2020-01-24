using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserStatus
{
    public class UserStatusDaoEF : BaseDaoEF<Model.UserStatus, long>, IUserStatusDao
    {
        public UserStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}

