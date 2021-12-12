using AspNETasmxWS.Entities;

namespace AspNETasmxWS.Infra.Services.Contracts {
    internal interface IMediaService {

        bool SaveMedia(Requisition requisition);
        bool GetMedia(Media media);
        bool DeleteMedia(Media media);

    }
}
