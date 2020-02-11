using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.Authentication.AuthenticationProvider.BasicAuth;
using University_Management_System_API.Authentication.AuthenticationProvider.TokenAuth;

namespace University_Management_System_API.Authentication.AuthenticationHendler
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IBasicAuthenticationProvider _basicProvider;
        public IBasicAuthenticationProvider BasicProvider
        {
            get { return _basicProvider; }
            set { _basicProvider = value; }
        }


        private ITokenAuthenticationProvider _tokenProvider;
        public ITokenAuthenticationProvider TokenProvider
        {
            get { return _tokenProvider; }
            set { _tokenProvider = value; }
        }

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            IBasicAuthenticationProvider basicProvider,
            ITokenAuthenticationProvider tokenProvider,
            ILoggerFactory logger,
            ISystemClock clock,
            UrlEncoder encoder)
            : base(options, logger, encoder, clock)
        {
            this.BasicProvider = basicProvider;
            this.TokenProvider = tokenProvider;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization Header not found");
            }

            UserResult resultUser;
            //Get Headers Value
            string authHeader = Request.Headers["Authorization"];

            try
            {
                if (authHeader != null && authHeader.StartsWith("Basic"))
                {
                    resultUser = await BasicProvider.AuthenticateAsync(Request);
                }
                else
                {
                    resultUser = await TokenProvider.AuthenticateAsync(Request);
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (resultUser == null)
                return AuthenticateResult.Fail("Invalid Username or Password");
         
            var ticket = await BasicProvider.BuilderAuthenticationTicket(resultUser, Scheme);

            return ticket;
        }
    }
}
