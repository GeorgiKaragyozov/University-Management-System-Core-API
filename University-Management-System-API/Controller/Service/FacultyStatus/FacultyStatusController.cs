using University_Management_System_API.Business.Convertor.FacultyStatus;
using University_Management_System_API.Business.Processor.FacultyStatus;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.FacultyStatus
{
    public class FacultyStatusController
        : BaseController<FacultyStatusParam, FacultyStatusResult, long, IFacultyStatusProcessor>
    {
        public FacultyStatusController(IFacultyStatusProcessor processor)
            : base(processor)
        {

        }
    }
}
