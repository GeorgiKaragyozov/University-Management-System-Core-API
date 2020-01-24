using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.SpecialityTrainingType
{
    public class SpecialityTrainingTypeDaoFile
        : BaseDaoFile<Model.SpecialityTrainingType, long, ISpecialityTrainingTypeStorage>,
        ISpecialityTrainingTypeDao
    {
        protected override long GetPK(Model.SpecialityTrainingType entity)
        {
            return entity.Id;
        }

        public SpecialityTrainingTypeDaoFile(ISpecialityTrainingTypeStorage storage)
          : base(storage)
        {

        }
    }
}
