using System;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http.Headers;
using System.Security.Claims;

namespace University_Management_System_API.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly UniversityManagementSystemContext _context;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            UniversityManagementSystemContext context)
            : base(options, logger, encoder, clock)
        {
            this._context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization Header not found");
            }

            try
            {
                var authenticationValues = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

                var bytes = Convert.FromBase64String(authenticationValues.Parameter);

                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string username = credentials[0];
                string password = credentials[1];

                Model.User user = _context.Users
                    .Where(
                        user => user.Username == username 
                        && user.Password == password)
                        .Single();

                if (user == null)
                {
                    return AuthenticateResult.Fail("Invalid Username or Password");
                }
                else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, user.Username) };
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

