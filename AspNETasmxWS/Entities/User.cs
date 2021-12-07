using AspNETasmxWS.Entities.Contracts;
using System;
using System.Security;

namespace AspNETasmxWS.Entities {
    public class User : IUser {

        public string Name { get => Name; set => Name = value; }
        public string Email { get => Email; set => Email = value; }
        public SecureString Password { get => Password; set => Password = value; }

    }
}