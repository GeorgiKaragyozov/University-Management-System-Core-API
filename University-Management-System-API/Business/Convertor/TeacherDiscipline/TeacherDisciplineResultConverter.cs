using University_Management_System_API.Business.Convertor.Common;

namespace University_Management_System_API.Business.Convertor.TeacherDiscipline
{
    public class TeacherDisciplineResultConverter 
        : BaseResultConverter<Model.TeacherDiscipline, TeacherDisciplineResult>,
           ITeacherDisciplineResultConverter
    {
        public override void ConvertSpecific(Model.TeacherDiscipline param,
            TeacherDisciplineResult result)
        {
            result.TeacherId = param.Account.Id;
            result.TeacherName = param.Account.Name;
            result.DisciplineId = param.Discipline.Id;
            result.DisciplineName = param.Discipline.Name;
            result.StatusId = param.Status.Id;
            result.StatusName = param.Status.Name;
        }

        public override TeacherDisciplineResult GetResult()
        {
            return new TeacherDisciplineResult();
        }
    }
}
