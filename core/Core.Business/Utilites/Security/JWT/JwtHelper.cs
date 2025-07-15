﻿using Core.Business.Utilites.Extensions;
using Core.Business.Utilites.Security.JWT.Encryptions;
using Core.Entity.Concrete;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilites.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            //var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenOptions.SecurityKey));
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            //var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);


            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtHandler = new JwtSecurityTokenHandler();
            var token = jwtHandler.WriteToken(jwt);

            return new AccessToken()
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user, SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                    issuer : tokenOptions.Issuer,
                    audience : tokenOptions.Audience,
                    expires : _accessTokenExpiration,
                    notBefore : DateTime.Now,
                    claims : SetClaims(user, operationClaims),
                    signingCredentials : signingCredentials
             );
            return jwt;
        }

        public IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims) 
        { 
            var claims = new List<Claim>();
            //claims.Add(new Claim("email",user.Email));
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName}{user.LastName}");
            claims.AddNameId(user.Id.ToString());
            claims.AddRoles(operationClaims.Select(oc => oc.Name).ToArray());
            return claims;
        }
    }
}
