using University_Management_System_API.DataAccess.DataAccessObject.Common;

namespace University_Management_System_API.DataAccess.DataAccessObject.Lecture
{
    public class LectureDaoFile : BaseDaoFile<Model.Lecture, long, ILectureStorage>, ILectureDao
    {
        protected override long GetPK(Model.Lecture entity)
        {
            return entity.Id;
        }

        public LectureDaoFile(ILectureStorage storage)
          : base(storage)
        {

        }
    }
}
