using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using University_Management_System_API.BasicAuthentication.AuthenticationProvider;
using University_Management_System_API.Business.Convertor.User;

namespace University_Management_System_API.BasicAuthentication.AuthenticationHendler
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IAuthenticationProvider _provider;
        public IAuthenticationProvider Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IAuthenticationProvider provider)
            : base(options, logger, encoder, clock)
        {
            this.Provider = provider;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization Header not found");
            }

            UserResult result = null;

            try
            {
                var authenticationValues = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

                var bytes = Convert.FromBase64String(authenticationValues.Parameter);

                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                UserParam param = new UserParam();

                param.Username = credentials[0];
                param.Password = credentials[1];

                result = await Provider.Authenticate(param);

                if (result == null)
                {
                    return AuthenticateResult.Fail("Invalid Username or Password");
                }
                else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, result.Username) };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }
            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("An Error has occured");
            }
        }
    }
}
