using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTWebAPI.Utils
{
    public class TokenAuthOption
    {
        public static string Audience { get; } = "http://localhost:52950/";
        public static string Issuer { get; } = "http://localhost:57855/";
        //public static string Issuer { get; } = "http://10.2.240.116/jwtapi";
        public static RsaSecurityKey Key { get; } = new RsaSecurityKey(RSAKeyHelper.GenerateKey());
        public static SigningCredentials SigningCredentials { get; } = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);

        public static TimeSpan TokenExpiretionTime = TimeSpan.FromMinutes(60);
    }
}
