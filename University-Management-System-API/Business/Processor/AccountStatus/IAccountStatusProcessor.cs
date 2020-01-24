using University_Management_System_API.Business.Convertor.AccountStatus;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.AccountStatus
{
    public interface IAccountStatusProcessor
        : IBaseProcessor<AccountStatusParam, AccountStatusResult, long>
    {

    }
}
