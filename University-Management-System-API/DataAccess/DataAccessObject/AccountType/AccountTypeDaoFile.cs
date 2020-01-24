using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.AccountType
{
    public class AccountTypeDaoFile : BaseDaoFile<Model.AccountType, long, IAccountTypeStorage>, IAccountTypeDao
    {
        protected override long GetPK(Model.AccountType entity)
        {
            return entity.Id;
        }

        public AccountTypeDaoFile(IAccountTypeStorage storage)
            : base(storage)
        {

        }
    }
}
