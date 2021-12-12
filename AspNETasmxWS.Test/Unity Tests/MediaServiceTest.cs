using AspNETasmxWS.Entities;
using AspNETasmxWS.Infra.DataAccess.Contracts;
using AspNETasmxWS.Infra.Services;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AspNETasmxWS.UnityTests.Test {


    [TestClass]
    public class MediaServiceTest {

        public IMediaDao mediaDaoMock;
        public MediaService mediaService;
        public Requisition requisitionMock;
        public Media mediaMock;

        [TestInitialize()]
        public void Initialize() {

            mediaDaoMock = A.Fake<IMediaDao>();
            mediaService = new MediaService(mediaDaoMock);
            requisitionMock = A.Fake<Requisition>();
            mediaMock = A.Fake<Media>();
        }

        [TestMethod]
        public void MediaService_WhenSaveMedia_IsFail() {

            //Arrange                       
            A.CallTo(() => mediaDaoMock.SaveMedia(requisitionMock)).Returns(false);

            //Act
            var assured = mediaService.SaveMedia(requisitionMock);

            //Assure
            Assert.IsFalse(assured);
        }

        [TestMethod]
        public void MediaService_WhenSaveMedia_IsSucceed() {

            //Arrange                       
            A.CallTo(() => mediaDaoMock.SaveMedia(requisitionMock)).Returns(true);

            //Act
            var assured = mediaService.SaveMedia(requisitionMock);

            //Assure
            Assert.IsTrue(assured);
        }

        [TestMethod]
        public void MediaService_WhenGetMedia_IsFail() {

            //Arrange
            A.CallTo(() => mediaDaoMock.GetMedia(mediaMock)).Returns(false);

            //Act
            var assured = mediaService.GetMedia(mediaMock);

            //Assure
            Assert.IsFalse(assured);
        }

        [TestMethod]
        public void MediaService_WhenGetMedia_IsSucceed() {

            //Arrange
            A.CallTo(() => mediaDaoMock.GetMedia(mediaMock)).Returns(true);

            //Act
            var assured = mediaService.GetMedia(mediaMock);

            //Assure
            Assert.IsTrue(assured);
        }

        [TestMethod]
        public void MediaService_WhenDeleteMedia_IsFail() {

            //Arrange                       
            A.CallTo(() => mediaDaoMock.DeleteMedia(mediaMock)).Returns(false);

            //Act
            var assured = mediaService.DeleteMedia(mediaMock);

            //Assure
            Assert.IsFalse(assured);
        }

        [TestMethod]
        public void MediaService_WhenDeleteMedia_IsSucceed() {

            //Arrange                       
            A.CallTo(() => mediaDaoMock.DeleteMedia(mediaMock)).Returns(true);

            //Act
            var assured = mediaService.DeleteMedia(mediaMock);

            //Assure
            Assert.IsTrue(assured);
        }

        [TestCleanup()]
        public void Cleanup()
        {
            mediaDaoMock = null;
            mediaService = null;
            requisitionMock = null;
            mediaMock = null;

        }
    }
}
