using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Account
{
    public class AccountDaoFile : BaseDaoFile<Model.Account, long, IAccountStorage>, IAccountDao
    {
        protected override long GetPK(Model.Account entity)
        {
            return entity.Id;
        }

        public AccountDaoFile(IAccountStorage storage)
            : base(storage)
        {

        }
    }
}
