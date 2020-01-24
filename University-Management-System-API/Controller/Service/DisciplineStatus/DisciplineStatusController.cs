using University_Management_System_API.Business.Convertor.DisciplineStatus;
using University_Management_System_API.Business.Processor.DisciplineStatus;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.DisciplineStatus
{
    public class DisciplineStatusController 
        : BaseController<DisciplineStatusParam, DisciplineStatusResult, long, IDisciplineStatusProcessor>
    {
        public DisciplineStatusController(IDisciplineStatusProcessor processor)
          : base(processor)
        {

        }
    }
}
