using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityStatus
{
    public class SpecialityStatusDaoEF : BaseDaoEF<Model.SpecialityStatus, long>, ISpecialityStatusDao
    {
        public SpecialityStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
