using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.EducationalDegree
{
    public class EducationalDegreeDaoFile
         : BaseDaoFile<Model.EducationalDegree, long, IEducationalDegreeStorage>, IEducationalDegreeDao
    {
        protected override long GetPK(Model.EducationalDegree entity)
        {
            return entity.Id;
        }

        public EducationalDegreeDaoFile(IEducationalDegreeStorage storage)
            : base(storage)
        {

        }
    }
}
