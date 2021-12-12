using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.UnityTests.Test {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;
    using System.Collections.Generic;

    [TestClass]
    public class MediaRemoveCommandTest    {

        public MediaRemoveCommand mediaRemoveCommand;
        public Media mediaMock;

        [TestInitialize()]
        public void Initialize() {

            mediaRemoveCommand = new MediaRemoveCommand();
            mediaMock = A.Fake<Media>();
        }

        [TestMethod]
        public void MediaRemoveCommand_WhenExecuteInsert_IsFail() {

            //Arrange                       

            //Act
            var assured = mediaRemoveCommand.Execute(mediaMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestCleanup()]
        public void Cleanup() {
            mediaRemoveCommand = null;
            mediaMock = null;
        }
    }
}
