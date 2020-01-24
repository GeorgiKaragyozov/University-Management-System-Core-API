using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.DepartamentStatus
{
    public class DepartamentStatusDaoEF : BaseDaoEF<Model.DepartamentStatus, long>, IDepartamentStatusDao
    {
        public DepartamentStatusDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }
    }
}
