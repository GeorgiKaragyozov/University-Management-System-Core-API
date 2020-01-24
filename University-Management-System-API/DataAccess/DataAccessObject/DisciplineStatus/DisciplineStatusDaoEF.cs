using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.DisciplineStatus
{
    public class DisciplineStatusDaoEF : BaseDaoEF<Model.DisciplineStatus, long>, IDisciplineStatusDao
    {
        public DisciplineStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
