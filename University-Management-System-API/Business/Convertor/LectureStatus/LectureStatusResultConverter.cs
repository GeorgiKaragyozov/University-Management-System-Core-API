using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.LectureStatus
{
    public class LectureStatusResultConverter 
        : BaseResultConverter<Model.LectureStatus, LectureStatusResult>, ILectureStatusResultConverter
    {
        public override void ConvertSpecific(Model.LectureStatus param, LectureStatusResult result) { }

        public override LectureStatusResult GetResult()
        {
            return new LectureStatusResult();
        }
    }
}
