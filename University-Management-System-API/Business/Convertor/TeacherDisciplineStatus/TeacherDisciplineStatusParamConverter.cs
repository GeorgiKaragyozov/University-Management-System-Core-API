using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.TeacherDisciplineStatus
{
    public class TeacherDisciplineStatusParamConverter 
        : BaseParamConverter<TeacherDisciplineStatusParam, Model.TeacherDisciplineStatus>,
          ITeacherDisciplineStatusParamConverter
    {
        public override Model.TeacherDisciplineStatus GetEntity(TeacherDisciplineStatusParam param)
        {
            return new Model.TeacherDisciplineStatus();
        }

        public override void ConvertSpecific(TeacherDisciplineStatusParam param,
            Model.TeacherDisciplineStatus entity)
        { }
    }
}
