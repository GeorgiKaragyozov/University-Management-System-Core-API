using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType
{
    public class SpecialityTrainingTypeDaoEF 
        : BaseDaoEF<Model.SpecialityTrainingType, long>, ISpecialityTrainingTypeDao
    {
        public SpecialityTrainingTypeDaoEF(UniversityManagementSystemContext context)
          : base(context)
        {

        }
    }
}
