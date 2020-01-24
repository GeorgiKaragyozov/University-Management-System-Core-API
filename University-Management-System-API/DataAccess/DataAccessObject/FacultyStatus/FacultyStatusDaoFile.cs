using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.FacultyStatus
{
    public class FacultyStatusDaoFile
        : BaseDaoFile<Model.FacultyStatus, long, IFacultyStatusStorage>, IFacultyStatusDao
    {
        protected override long GetPK(Model.FacultyStatus entity)
        {
            return entity.Id;
        }

        public FacultyStatusDaoFile(IFacultyStatusStorage storage)
            : base(storage)
        {

        }
    }
}
