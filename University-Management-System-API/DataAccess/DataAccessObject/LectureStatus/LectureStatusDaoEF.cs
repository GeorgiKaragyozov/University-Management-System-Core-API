using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDaoEF : BaseDaoEF<Model.LectureStatus, long>, ILectureStatusDao
    {
        public LectureStatusDaoEF(UniversityManagementSystemContext context)
           : base(context)
        {

        }
    }
}
