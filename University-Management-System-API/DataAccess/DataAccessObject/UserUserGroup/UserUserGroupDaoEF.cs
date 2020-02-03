using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    public class UserUserGroupDaoEF : BaseDaoEF<Model.UserUserGroup, long>, IUserUserGroupDao
    {
        public UserUserGroupDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {

        }

        public async Task<List<string>> GetUserGroupsAsync(Model.UserUserGroup entity)
        {
            List<string> ListRoles = await Task.Run(() => _dbContext.UserUserGroups
                .Where(e => e.User.Id == entity.User.Id)
                .Select(r => r.UserGroup.Name)
                .ToList());

            return ListRoles;
        }
    }
}
