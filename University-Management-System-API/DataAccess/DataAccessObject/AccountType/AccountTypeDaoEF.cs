using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.AccountType
{
    public class AccountTypeDaoEF : BaseDaoEF<Model.AccountType, long>, IAccountTypeDao
    {
        public AccountTypeDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {

        }
    }
}
