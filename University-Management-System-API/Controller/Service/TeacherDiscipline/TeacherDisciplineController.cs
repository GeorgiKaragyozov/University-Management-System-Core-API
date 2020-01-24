using University_Management_System_API.Business.Convertor.TeacherDiscipline;
using University_Management_System_API.Business.Processor.TeacherDiscipline;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.TeacherDiscipline
{
    public class TeacherDisciplineController
        : BaseController<TeacherDisciplineParam, TeacherDisciplineResult, long, ITeacherDisciplineProcessor>
    {
        public TeacherDisciplineController(ITeacherDisciplineProcessor processor)
            : base(processor)
        {

        }
    }
}
