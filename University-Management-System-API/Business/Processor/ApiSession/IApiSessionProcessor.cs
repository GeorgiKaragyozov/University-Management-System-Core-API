using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.ApiSession;
using University_Management_System_API.Business.Processor.Common;

namespace University_Management_System_API.Business.Processor.ApiSession
{
    public interface IApiSessionProcessor : IBaseProcessor<ApiSessionParam, ApiSessionResult, long>
    {
        Task<ApiSessionResult> GetByAuthTokenAsync(string authToken);
    }
}
