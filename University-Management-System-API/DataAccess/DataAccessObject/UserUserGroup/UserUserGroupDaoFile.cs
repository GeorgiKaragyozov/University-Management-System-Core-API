using System.Threading.Tasks;
using System.Collections.Generic;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    public class UserUserGroupDaoFile
        : BaseDaoFile<Model.UserUserGroup, long, IUserUserGroupStorage>, IUserUserGroupDao
    {
        protected override long GetPK(Model.UserUserGroup entity)
        {
            return entity.Id;
        }

        public Task<List<string>> GetUserGroupsAsync(Model.UserUserGroup entity)
        {
            throw new System.NotImplementedException();
        }

        public UserUserGroupDaoFile(IUserUserGroupStorage storage)
          : base(storage)
        {

        }
    }
}
