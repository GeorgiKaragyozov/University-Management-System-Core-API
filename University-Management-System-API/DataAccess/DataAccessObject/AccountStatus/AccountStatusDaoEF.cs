using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusDaoEF : BaseDaoEF<Model.AccountStatus, long>, IAccountStatusDao
    {
        public AccountStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
