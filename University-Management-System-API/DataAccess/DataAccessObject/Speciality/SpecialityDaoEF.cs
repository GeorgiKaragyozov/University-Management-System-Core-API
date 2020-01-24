using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Speciality
{
    public class SpecialityDaoEF : BaseDaoEF<Model.Speciality, long>, ISpecialityDao
    {
        public SpecialityDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
