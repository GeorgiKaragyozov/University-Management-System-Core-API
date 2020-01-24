using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDaoEF : BaseDaoEF<Model.FacultyStatus, long>, IFacultyStatusDao
    {
        public FacultyStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
