using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Discipline
{
    public class DisciplineDaoEF : BaseDaoEF<Model.Discipline, long>, IDisciplineDao
    {
        public DisciplineDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
