using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.UnityTests.Test {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;
    using AspNETasmxWS.Responses.Contracts;
    using System.Collections.Generic;

    [TestClass]
    public class MediaInsertCommandTest {

        public MediaInsertCommand mediaInsertCommand;
        public Requisition requisitionMock;

        [TestInitialize()]
        public void Initialize() {

            mediaInsertCommand = new MediaInsertCommand();
            requisitionMock = A.Fake<Requisition>();
        }

        [TestMethod]
        public void MediaInsertCommand_WhenExecuteInsert_IsFail() {

            //Arrange
            var mockResponse = A.Fake<IResponse>();

            //Act
            var assured = mediaInsertCommand.Execute(requisitionMock);

            //Assure
            Assert.AreNotEqual(assured, mockResponse);

        }

        [TestCleanup()]
        public void Cleanup() {
            mediaInsertCommand = null;
            requisitionMock = null;
        }
    }
}
