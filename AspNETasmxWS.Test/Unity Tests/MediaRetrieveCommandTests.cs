using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.UnityTests.Test {

    using AspNETasmxWS.Commands;
    using AspNETasmxWS.Entities;

    [TestClass]
    public class MediaRetrieveCommandTests {

        public MediaRetrieveCommand mediaRetrieveCommand;
        public Media mediaMock;

        [TestInitialize()]
        public void Initialize() {

            mediaRetrieveCommand = new MediaRetrieveCommand();
            mediaMock = A.Fake<Media>();
        }

        [TestMethod]
        public void MediaRetrieveCommand_WhenExecuteInsert_IsFail() {

            //Arrange                       

            //Act
            var assured = mediaRetrieveCommand.Execute(mediaMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestCleanup()]
        public void Cleanup() {

            mediaRetrieveCommand = null;
            mediaMock = null;
        }
    }
}
