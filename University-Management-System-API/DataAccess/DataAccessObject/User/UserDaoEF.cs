using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    public class UserDaoEF : BaseDaoEF<Model.User, long>, IUserDao
    {
        public UserDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }
    }
}
