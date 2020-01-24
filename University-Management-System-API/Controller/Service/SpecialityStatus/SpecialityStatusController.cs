using University_Management_System_API.Business.Convertor.SpecialityStatus;
using University_Management_System_API.Business.Processor.SpecialityStatus;
using University_Management_System_API.Controller.Service.Common;

namespace University_Management_System_API.Controller.Service.SpecialityStatus
{
    public class SpecialityStatusController
         : BaseController<SpecialityStatusParam, SpecialityStatusResult, long, ISpecialityStatusProcessor>
    {
        public SpecialityStatusController(ISpecialityStatusProcessor processor)
             : base(processor)
        {

        }
    }
}
