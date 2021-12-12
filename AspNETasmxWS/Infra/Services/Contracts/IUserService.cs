using AspNETasmxWS.Entities;

namespace AspNETasmxWS.Infra.Services.Contracts {
    
    internal interface IUserService {
        
        bool LoginUser(User user);
        
    }
}
