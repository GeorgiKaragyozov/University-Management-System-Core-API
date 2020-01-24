using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree
{
    public class EducationalDegreeDaoEF : BaseDaoEF<Model.EducationalDegree, long>, IEducationalDegreeDao
    {
        public EducationalDegreeDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
