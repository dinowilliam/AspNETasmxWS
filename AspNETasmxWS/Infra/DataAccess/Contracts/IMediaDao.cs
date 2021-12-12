using AspNETasmxWS.Entities;

namespace AspNETasmxWS.Infra.DataAccess.Contracts
{
    public interface IMediaDao {

        bool SaveMedia(Requisition requisition);
        bool GetMedia(Media media);
        bool DeleteMedia(Media media);
        int Count { get; }
        bool IsConnected { get; }        

    }
}
