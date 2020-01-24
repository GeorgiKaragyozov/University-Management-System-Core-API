using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Account
{
    public class AccountDaoEF : BaseDaoEF<Model.Account, long>, IAccountDao
    {
        public AccountDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }
    }
}
