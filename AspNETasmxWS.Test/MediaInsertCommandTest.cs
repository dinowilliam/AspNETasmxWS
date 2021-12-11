using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.Test {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;
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
        public void MediaInsertCommand_WhenExecuteInsert_IsFailed() {

            //Arrange                       

            //Act
            var assured = mediaInsertCommand.Execute(requisitionMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestCleanup()]
        public void Cleanup() {
            mediaInsertCommand = null;
            requisitionMock = null;
        }
    }
}
