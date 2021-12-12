using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETasmxWS.Test {

    using AspNETasmxWS.Entities;
    using AspNETasmxWS.Infra.DataAccess;

    [TestClass]
    public class MediaDaoTest{

        public MediaDao mediaDao;
        public Requisition requisitionMock;
        public Media mediaMock;

        [TestInitialize()]
        public void Initialize() {
            
            mediaDao = new MediaDao();
            requisitionMock = A.Fake<Requisition>();
            mediaMock = A.Fake<Media>();
        }

        [TestMethod]
        public void MediaDao_WhenSaveMedia_IsFail() {

            //Arrange                       

            //Act
            var assured = mediaDao.SaveMedia(requisitionMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestMethod]
        public void MediaDao_WhenGetMedia_IsFail() {

            //Arrange                       

            //Act
            var assured = mediaDao.GetMedia(mediaMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestMethod]
        public void MediaDao_WhenDeleteMedia_IsFail() {

            //Arrange                       

            //Act
            var assured = mediaDao.DeleteMedia(mediaMock);

            //Assure
            Assert.IsFalse(assured);

        }

        [TestCleanup()]
        public void Cleanup() {

            mediaDao = null;
            requisitionMock = null;
            mediaMock = null;

        }
    }
}
