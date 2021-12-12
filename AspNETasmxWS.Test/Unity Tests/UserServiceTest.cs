using AspNETasmxWS.Entities;
using AspNETasmxWS.Infra.DataAccess.Contracts;
using AspNETasmxWS.Infra.Services;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AspNETasmxWS.UnityTests.Test {


    [TestClass]
    public class UserServiceTest   {

        public IUserDao userDaoMock;
        public UserService userService;        
        public User userMock;

        [TestInitialize()]
        public void Initialize() {

            userDaoMock = A.Fake<IUserDao>();
            userService = new UserService(userDaoMock);
            userMock = A.Fake<User>();            
        }

        [TestMethod]
        public void UserService_WhenSaveLoginUser_IsFail() {

            //Arrange                       
            A.CallTo(() => userDaoMock.LoginUser(userMock)).Returns(false);

            //Act
            var assured = userService.LoginUser(userMock);

            //Assure
            Assert.IsFalse(assured);
        }

        [TestMethod]
        public void UserService_WhenSaveLoginUser_IsSucceed() {

            //Arrange                       
            A.CallTo(() => userDaoMock.LoginUser(userMock)).Returns(true);

            //Act
            var assured = userService.LoginUser(userMock);

            //Assure
            Assert.IsTrue(assured);
        }
        

        [TestCleanup()]
        public void Cleanup() {

            userDaoMock = null;
            userService = null;            
            userMock = null;

        }
    }
}
