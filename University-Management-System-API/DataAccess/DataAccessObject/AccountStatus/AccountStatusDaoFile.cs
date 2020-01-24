﻿using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.AccountStatus
{
    public class AccountStatusDaoFile
        : BaseDaoFile<Model.AccountStatus, long, IAccountStatusStorage>, IAccountStatusDao
    {
        protected override long GetPK(Model.AccountStatus entity)
        {
            return entity.Id;
        }

        public AccountStatusDaoFile(IAccountStatusStorage storage)
            : base(storage)
        {

        }
    }
}
