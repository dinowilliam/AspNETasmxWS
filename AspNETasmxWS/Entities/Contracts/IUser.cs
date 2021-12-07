using System.Security;

namespace AspNETasmxWS.Entities.Contracts {

    public interface IUser {        
        string Name { get; set;  }
        string Email { get; set;  }
        SecureString Password { get; set; }
    }

}
