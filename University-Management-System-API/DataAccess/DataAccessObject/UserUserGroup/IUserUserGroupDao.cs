using System.Collections.Generic;
using System.Threading.Tasks;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.UserUserGroup
{
    public interface IUserUserGroupDao : IBaseDao<Model.UserUserGroup, long>
    {
        Task<List<string>> GetUserGroupsAsync(Model.UserUserGroup entity);
    }
}
