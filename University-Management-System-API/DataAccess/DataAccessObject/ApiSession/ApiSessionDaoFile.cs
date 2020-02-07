using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.ApiSession
{
    public class ApiSessionDaoFile : BaseDaoFile<Model.ApiSession, long, IApiSessionStorage>, IApiSessionDao
    {
        protected override long GetPK(Model.ApiSession entity)
        {
            return entity.Id;
        }

        public ApiSessionDaoFile(IApiSessionStorage storage)
            : base(storage)
        {

        }
    }
}
