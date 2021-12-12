using AspNETasmxWS.Entities;
using AspNETasmxWS.Infra.DataAccess.Contracts;
using AspNETasmxWS.Infra.Services.Contracts;

namespace AspNETasmxWS.Infra.Services
{
    public class UserService : IUserService {

        private readonly IUserDao _userDao;
        public UserService(IUserDao userDao) { 
            this._userDao = userDao;
        }
        public bool LoginUser(User user){

            return _userDao.LoginUser(user);

        }
    }
}