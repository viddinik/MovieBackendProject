using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business.Utilites.Security.JWT
{
    public class TokenOptions
    {
        public string Audience { get; set; } // token kullanıcı listesini tutar
        public string Issuer { get; set; } // token izmalayan
        public int AccessTokenExpiration { get; set; } // token geçerlilik süresi (dakika cinsinden)
        public string SecurityKey { get; set; } // güvenlik anahtarı
    }
}
