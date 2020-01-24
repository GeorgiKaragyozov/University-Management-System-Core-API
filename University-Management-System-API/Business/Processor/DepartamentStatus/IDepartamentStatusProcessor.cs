using University_Management_System_API.Business.Convertor.DepartamentStatus;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.DepartamentStatus
{
    public interface IDepartamentStatusProcessor
         : IBaseProcessor<DepartamentStatusParam, DepartamentStatusResult, long>
    {

    }
}
