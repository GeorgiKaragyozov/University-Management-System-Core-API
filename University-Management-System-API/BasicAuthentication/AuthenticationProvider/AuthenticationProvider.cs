using System.Threading.Tasks;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Business.Processor.User;

namespace University_Management_System_API.BasicAuthentication.AuthenticationProvider
{
    public class AuthenticationProvider : IAuthenticationProvider
    {
        private IUserProcessor _processorUser;
        public IUserProcessor ProcessorUser
        {
            get { return _processorUser; }
            set { _processorUser = value; }
        }

        public AuthenticationProvider(IUserProcessor ProcessorUser)
        {
            this.ProcessorUser = ProcessorUser;
        }

        public async Task<UserResult> Authenticate(UserParam param)
        {
            UserResult result = await ProcessorUser.Authenticate(param);

            return result;
        }
    }
}
