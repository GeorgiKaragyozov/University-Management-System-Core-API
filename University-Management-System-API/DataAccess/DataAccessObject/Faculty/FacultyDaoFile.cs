using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Faculty
{
    public class FacultyDaoFile : BaseDaoFile<Model.Faculty, long, IFacultyStorage>, IFacultyDao
    {
        protected override long GetPK(Model.Faculty entity)
        {
            return entity.Id;
        }

        public FacultyDaoFile(IFacultyStorage storage)
            : base(storage)
        {

        }
    }
}
