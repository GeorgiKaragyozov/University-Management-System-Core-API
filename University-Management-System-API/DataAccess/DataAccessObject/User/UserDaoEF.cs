using System.Linq;
using System.Threading.Tasks;
using University_Management_System_API.DataAccess.DataAccessObject.Common;
using University_Management_System_API.Model;

namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    public class UserDaoEF : BaseDaoEF<Model.User, long>, IUserDao
    {
        public UserDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }

        public async Task<Model.User> AuthenticateAsync(Model.User entity)
        {
            Model.User user = await Task.Run(() => _dbContext.Users.SingleOrDefault(
                e => e.Username == entity.Username &&
                e.Password == entity.Password));

            return user;
        }
    }
}
