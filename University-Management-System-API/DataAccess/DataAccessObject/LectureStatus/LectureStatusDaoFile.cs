using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.LectureStatus
{
    public class LectureStatusDaoFile
        : BaseDaoFile<Model.LectureStatus, long, ILectureStatusStorage>, ILectureStatusDao
    {
        protected override long GetPK(Model.LectureStatus entity)
        {
            return entity.Id;
        }

        public LectureStatusDaoFile(ILectureStatusStorage storage)
           : base(storage)
        {

        }
    }
}
