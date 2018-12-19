using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SaveImage
{
    struct AuthRequestInfo
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public AuthRequestInfo(string _login, string _password)
        {
            Login = _login;
            Password = _password;
        }
    }
}
