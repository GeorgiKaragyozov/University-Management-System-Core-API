using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    public class ApiSessionDaoEF : BaseDaoEF<Model.ApiSession, long>, IApiSessionDao
    {
        public ApiSessionDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }
    }
}
