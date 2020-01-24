using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusResultConverter 
        : BaseResultConverter<Model.TeacherDisciplineStatus, TeacherDisciplineStatusResult>,
            ITeacherDisciplineStatusResultConverter
    {
        public override void ConvertSpecific(Model.TeacherDisciplineStatus param,
            TeacherDisciplineStatusResult result)
        { }

        public override TeacherDisciplineStatusResult GetResult()
        {
            return new TeacherDisciplineStatusResult();
        }
    }
}
