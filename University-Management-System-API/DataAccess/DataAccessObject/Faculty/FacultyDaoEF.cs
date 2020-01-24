using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDaoEF : BaseDaoEF<Model.Faculty, long>, IFacultyDao
    {
        public FacultyDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
