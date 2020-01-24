using University_Management_System_API.Business.Convertor.DisciplineStatus;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.DisciplineStatus
{
    public interface IDisciplineStatusProcessor
        : IBaseProcessor<DisciplineStatusParam, DisciplineStatusResult, long>
    {

    }
}
