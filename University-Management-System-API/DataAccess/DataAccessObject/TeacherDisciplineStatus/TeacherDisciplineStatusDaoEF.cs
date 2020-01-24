using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusDaoEF : BaseDaoEF<Model.TeacherDisciplineStatus, long>,
        ITeacherDisciplineStatusDao
    {
        public TeacherDisciplineStatusDaoEF(UniversityManagementSystemContext context)
            : base(context)
        {

        }
    }
}
