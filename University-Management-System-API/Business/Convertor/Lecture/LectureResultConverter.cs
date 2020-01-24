using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.Lecture
{
    public class LectureResultConverter 
        : BaseResultConverter<Model.Lecture, LectureResult>, ILectureResultConverter
    {
        public override void ConvertSpecific(Model.Lecture param, LectureResult result)
        {
            result.TeacherDisciplineId = param.TeacherDiscipline.Id;
            result.TeacherDisciplineName = param.TeacherDiscipline.Name;
            result.RoomId = param.Room.Id;
            result.RoomName = param.Room.Name;
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override LectureResult GetResult()
        {
            return new LectureResult();
        }
    }
}
