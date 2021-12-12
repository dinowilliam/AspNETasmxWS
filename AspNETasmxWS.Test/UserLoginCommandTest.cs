using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.Test {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;
    using System.Collections.Generic;

    [TestClass]
    public class UserLoginCommandTest {

        public UserLoginCommand userLoginCommand;
        public User userMock;

        [TestInitialize()]
        public void Initialize() {

            userLoginCommand = new UserLoginCommand();
            userMock = A.Fake<User>();
        }

        [TestMethod]
        public void UserLoginCommand_WhenExecuteLogin_IsFail() {

            //Arrange                       

            //Act
            var assured = userLoginCommand.Execute(userMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestCleanup()]
        public void Cleanup() {
            userLoginCommand = null;
            userMock = null;
        }
    }
}
