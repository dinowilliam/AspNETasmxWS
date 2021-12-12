using AspNETasmxWS.Entities;
using AspNETasmxWS.Infra.DataAccess.Contracts;
using AspNETasmxWS.Infra.Services.Contracts;

namespace AspNETasmxWS.Infra.Services {
    public class MediaService : IMediaService    {

        private readonly IMediaDao _mediaDao;

        public MediaService(IMediaDao mediaDao) { 
            this._mediaDao = mediaDao;
        }

        public bool DeleteMedia(Media media) {

            return _mediaDao.DeleteMedia(media);
        }

        public bool GetMedia(Media media){

            return _mediaDao.GetMedia(media);
        }

        public bool SaveMedia(Requisition requisition){

            return _mediaDao.SaveMedia(requisition);
        }
    }
}