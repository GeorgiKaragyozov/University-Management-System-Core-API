﻿using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserGroup
{
    public class UserGroupDaoFile : BaseDaoFile<Model.UserGroup, long, IUserGroupStorage>, IUserGroupDao
    {
        protected override long GetPK(Model.UserGroup entity)
        {
            return entity.Id;
        }

        public UserGroupDaoFile(IUserGroupStorage storage)
          : base(storage)
        {

        }
    }
}
