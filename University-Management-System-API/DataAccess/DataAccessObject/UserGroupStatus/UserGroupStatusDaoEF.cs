using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroupStatus
{
    public class UserGroupStatusDaoEF : BaseDaoEF<Model.UserGroupStatus, long>, IUserGroupStatusDao
    {
        public UserGroupStatusDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {

        }
    }
}
