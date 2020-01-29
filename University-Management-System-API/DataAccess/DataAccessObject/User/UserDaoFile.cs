using System.Threading.Tasks;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.User
{
    public class UserDaoFile : BaseDaoFile<Model.User, long, IUserStorage>, IUserDao
    {
        protected override long GetPK(Model.User entity)
        {
            return entity.Id;
        }

        public Task<Model.User> Authenticate(Model.User entity)
        {
            throw new System.NotImplementedException();
        }

        public UserDaoFile(IUserStorage storage)
          : base(storage)
        {

        }
    }
}
