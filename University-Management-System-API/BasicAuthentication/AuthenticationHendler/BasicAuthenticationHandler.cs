using System.Security.Claims;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using University_Management_System_API.Business.Convertor.User;
using University_Management_System_API.BasicAuthentication.AuthenticationProvider;

namespace University_Management_System_API.BasicAuthentication.AuthenticationHendler
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IBasicAuthenticationProvider _basicProvider;
        public IBasicAuthenticationProvider BasicProvider
        {
            get { return _basicProvider; }
            set { _basicProvider = value; }
        }

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IBasicAuthenticationProvider basicProvider)
            : base(options, logger, encoder, clock)
        {
            this.BasicProvider = basicProvider;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization Header not found");
            }

            UserResult resultUser;
            List<string> listUserGroups;

            try
            {
                resultUser = await BasicProvider.AuthenticateAsync(Request);

                listUserGroups = await BasicProvider.GetUserGroupsAsync(resultUser);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (resultUser == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            IList<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, resultUser.Id.ToString()),
                new Claim(ClaimTypes.Name, resultUser.Username)
            };

            //User Roles
            listUserGroups.ForEach(userGroups => 
                claims.Add(new Claim(ClaimTypes.Role, userGroups)));

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
