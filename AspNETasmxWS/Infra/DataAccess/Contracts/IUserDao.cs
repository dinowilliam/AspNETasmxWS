using AspNETasmxWS.Entities;

namespace AspNETasmxWS.Infra.DataAccess.Contracts
{
    public interface IUserDao {

        bool LoginUser(User user);        

    }
}
