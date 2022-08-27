using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace CRM.Application.User.Login
{
    public class LoginAccountRequestDTO
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        private string IdRole { get; set; }
    }
}
