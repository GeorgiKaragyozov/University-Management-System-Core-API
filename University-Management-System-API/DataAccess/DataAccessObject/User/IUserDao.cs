using System.Threading.Tasks;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    public interface IUserDao : IBaseDao<Model.User, long>
    {
        Task<Model.User> Authenticate(Model.User entity);
    }
}
