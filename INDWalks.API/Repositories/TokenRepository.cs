using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace INDWalks.API.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly IConfiguration configuration;

        public TokenRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //So this basically returns the string token that we want to use inside the controller.
        public string CreateJWTToken(IdentityUser user, List<string> roles)
        {

            //Claims are used to make access control desicions. Like we can use claims to allow a logged-in user to edit employee details if they have "EDIT EMPLOYEE" claim.
            // Create claims 
            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Email, user.Email));

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //creating our token
            var token = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);

            //instantites the new JWT secuity token handler and uses the WriteToken method, it exposes writes  and exposes the token for us.
             
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
