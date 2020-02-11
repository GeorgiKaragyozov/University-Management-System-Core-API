using System.Linq;
using System.Threading.Tasks;
using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    public class ApiSessionDaoEF : BaseDaoEF<Model.ApiSession, long>, IApiSessionDao
    {
        public ApiSessionDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }

        public async Task<Model.ApiSession> GetByAuthTokenAsync(string authToken)
        {
            Model.ApiSession entity = await Task.Run(() =>
               _dbContext.ApiSessions.SingleOrDefault(
                e => e.AuthToken == authToken));

            return entity;
        }
    }
}
