using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiHWebApp.Shared.Utilities
{
    public class JwtConfiguration
    {
        public string Key = "6AD2EFDE-AB2C-4841-A05E-7045C855BA22";
        public string Issuer = "https://localhost:5290";
        public string Audience = "https://localhost:5291";
        public string ExpiryInDay = "1";
    }
}
