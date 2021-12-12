using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.UnityTests.Test {

    using AspNETasmxWS.Entities;
    using AspNETasmxWS.Infra.DataAccess;

    [TestClass]
    public class UserDaoTest {

        public UserDao userDao;
        public User userMock;
        
        [TestInitialize()]
        public void Initialize() {
            
            userDao = new UserDao();
            userMock = A.Fake<User>();            
        }

        [TestMethod]
        public void UserDao_WhenLoginUser_IsFail() {

            //Arrange                       

            //Act
            var assured = userDao.LoginUser(userMock);

            //Assure
            Assert.IsFalse(assured);

        }
        

        [TestCleanup()]
        public void Cleanup() {

            userDao = null;
            userMock = null;            
        }
    }
}
