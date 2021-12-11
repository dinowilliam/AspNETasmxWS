
namespace AspNETasmxWS.Infra.DataAccess {

    using AspNETasmxWS.Entities;
    using AspNETasmxWS.Infra.DataAccess.Contracts;

    public class MediaDao : IMediaDao {

        public MediaDao() { 
        
        }

        public bool SaveMedia(Requisition requisition) {

            return false;
        }

        public bool GetMedia(Media media) {

            return false;
        }

        public bool DeleteMedia(Media media) {
            
            return false;
        }

        public int Count => 0;

        public bool IsConnected => false;

    }
}