using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using CRM.Application.Common;

namespace CRM.Application.User.Login
{
    public class LoginAccountResponseDTO : Result
    {
        public long IdUser { get; set; }
        public string Token { get; set; }
        public int ExpirationTime { get; set; }
    }
}
